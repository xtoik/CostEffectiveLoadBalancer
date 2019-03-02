namespace CostEffectiveLoadBalancer.Dal
{
    using CostEffectiveLoadBalancer.Dal.Extensions;
    using CostEffectiveLoadBalancer.Domain.Entity;
    using Microsoft.EntityFrameworkCore;

    public class CostEffectiveLoadBalancerContext : DbContext
    {
        public CostEffectiveLoadBalancerContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }

        public DbSet<Endpoint> Endpoints { get; set; }

        public DbSet<Limit> Limits { get; set; }

        public DbSet<LimitConsumption> LimitConsumptions { get; set; }

        public DbSet<LimitType> LimitTypes { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet<ProviderEndpoint> ProviderEndpoints { get; set; }

        public DbSet<ProviderEndpointConsumption> ProviderEndpointConsumptions { get; set; }

        public DbSet<ResourceType> ResourceTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}