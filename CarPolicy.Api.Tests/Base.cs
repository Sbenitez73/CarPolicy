
namespace CarPolicy.Api.Tests
{
    using AutoMapper;
    using Data.Mappings;
    using Microsoft.EntityFrameworkCore;
    using NetTopologySuite;
    using Search.Api.Contexts;


    public class Base
    {
        protected ApplicationDbContext BuildContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            var dbContext = new ApplicationDbContext(options);

            return dbContext;
        }

        protected IMapper BuildMapper()
        {
            var config = new MapperConfiguration(options =>
            {
                var geometryFactory = NtsGeometryServices.Instance.CreateGeometryFactory(srid: 4326);
                options.AddProfile(new AutoMapperProfiles());

            });

            return config.CreateMapper();
        }

    }
}
