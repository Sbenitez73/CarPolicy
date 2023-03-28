namespace CarPolicy.Controllers
{
    using AutoMapper;
    using Dtos.Common;
    using Infrastructure;
    using Infrastructure.Messages;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Search.Api.Contexts;

    [ApiController]
    [Route("api/policy")]
    public class PolicyController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public PolicyController(ApplicationDbContext context, IMapper mapper )
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet( "{index}" )]
        [Authorize( AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme )]
        [ProducesResponseType( typeof( Dtos.Policy ), 200 )]
        [ProducesResponseType( typeof( ErrorResponse ), 401 )]
        [ProducesResponseType( typeof( ErrorResponse ), 400 )]
        [ProducesResponseType( typeof( ErrorResponse ), 404 )]
        [ProducesResponseType( typeof( ErrorResponse ), 409 )]
        public async Task<ActionResult<Dtos.Policy>> GetPolicy( string index)
        {   
            Throw.When<CustomNotFoundException>(index == null, "Bad parameter, check your url");

            var policy = await context.Policies.FirstOrDefaultAsync(p =>  Equals( p.CarRegistration, index ) );
           
            Throw.When<CustomNotFoundException>(policy == null, "Policy not founded");

            return this.mapper.Map<Dtos.Policy>( policy);
        }
    }
}
