namespace CostEffectiveLoadBalancer.Domain.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ProviderEndpointConsumption
    {
        public int Id { get; set; }

        [Required]
        public int ProviderEndpointId { get; set; }

        [Required]
        public DateTime Happened { get; set; }

        [Required]
        public int DurationMilliseconds { get; set; }

        [Required]
        public int InBytes { get; set; }

        [Required]
        public int OutBytes { get; set; }

        public virtual ProviderEndpoint ProviderEndpoint { get; set; }
    }
}