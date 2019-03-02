namespace CostEffectiveLoadBalancer.Dal.Extensions
{
    using Domain.Entity;
    using Microsoft.EntityFrameworkCore;

    internal static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Provider>().HasData(
                new Provider
                {
                    Id = int.MinValue,
                    Name = "Azure",
                    Description = "Microsoft Azure"
                }
            );
            
            modelBuilder.Entity<Provider>().HasData(
                new Provider
                {
                    Id = int.MinValue + 1,
                    Name = "AWS",
                    Description = "Amazon Web Services"
                }
            );
        }
    }
}