namespace CarPolicy.Search.Api.Contexts
{
    using Common.Api.Seed;
    using Domain.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Policy> Policies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                                     .SetBasePath(Directory.GetCurrentDirectory())
                                     .AddJsonFile("appsettings.json")
                                     .Build();

            var connectionString = configuration.GetConnectionString("defaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var policies = InitialSeed.GetPolicySeed();

            modelBuilder.Entity<Policy>().HasData(policies);
            modelBuilder.Entity<Policy>().HasQueryFilter(p => p.TakenPolicyDate > DateTime.Now);

            base.OnModelCreating(modelBuilder);
        }
    }
}
