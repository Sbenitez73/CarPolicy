namespace CarPolicy.Search.Api.Controllers
{
    using CarPolicy.Common.Api.Utilities;
    using Dtos;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.IdentityModel.Tokens;
    using System.IdentityModel.Tokens.Jwt;
    using System.Security.Claims;

    [ApiController]
    [Route( "api/auth" )]
    public class AuthController: ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;
        private readonly SignInManager<IdentityUser> signInManager;

        public AuthController( UserManager<IdentityUser> userManager,
                               IConfiguration configuration,
                               SignInManager<IdentityUser> signInManager )
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.signInManager = signInManager;
        }

        [HttpPost("register")]
        public async Task<ActionResult<AuthResponse>>Register( UserCredentials credentials )
        {
            var user = new IdentityUser 
            { 
                UserName = credentials.Email, 
                Email = credentials.Email 
            };
            var result = await userManager.CreateAsync( user, credentials.Password );

            if( result.Succeeded )
            {
                var actions = new TokenActions(this.configuration);
                return actions.BuildToken(credentials);
            } 
            else
            {
                return BadRequest( result.Errors );
            }
        }

        [HttpPost("login")]
        public async Task<ActionResult<AuthResponse>>Login( UserCredentials credentials )
        {
            var result = await this.signInManager.PasswordSignInAsync( credentials.Email,
                                                                       credentials.Password,
                                                                       lockoutOnFailure: false,
                                                                       isPersistent: false );

            if( result.Succeeded )
            {
                var actions = new TokenActions(this.configuration);
                return actions.BuildToken(credentials);
            }
            else
            {
                return BadRequest("Incorrect credentials");
            }
        }
    }
}
