namespace CarPolicy.Common.Api.Utilities
{

    using Dtos;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;
    using System.Text;

    public class TokenActions
    {
        private readonly IConfiguration configuration;

        public TokenActions( IConfiguration configuration )
        {
            this.configuration = configuration;
        }

        public AuthResponse BuildToken(UserCredentials credential)
        {
            var claims = new List<Claim>()
            {
                new Claim( "email", credential.Email )
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["llavejwt"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiration = DateTime.UtcNow.AddYears(1);

            var securityToken = new JwtSecurityToken(issuer: null, audience: null, claims: claims, expires: expiration, signingCredentials: creds);

            return new AuthResponse()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(securityToken),
                ExpirationDate = expiration,
            };
        }
    }
}
