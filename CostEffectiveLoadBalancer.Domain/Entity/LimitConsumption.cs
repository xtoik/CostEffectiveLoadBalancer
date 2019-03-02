namespace CostEffectiveLoadBalancer.Domain.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class LimitConsumption
    {
        public int Id { get; set; }

        [Required]
        public int LimitId { get; set; }

        [Required]
        public DateTime PeriodStart { get; set; }

        [Required]
        public DateTime PeriodEnd { get; set; }

        [Required]
        public int Value { get; set; }

        public virtual Limit Limit { get; set; }
    }
}