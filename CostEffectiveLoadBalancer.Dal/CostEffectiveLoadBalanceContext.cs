namespace CostEffectiveLoadBalancer.Dal
{
    using CostEffectiveLoadBalancer.Domain.Entity;
    using Microsoft.EntityFrameworkCore;

    public class CostEffectiveLoadBalanceContext : DbContext
    {
        public CostEffectiveLoadBalanceContext(DbContextOptions opt) : base(opt)
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
    }
}