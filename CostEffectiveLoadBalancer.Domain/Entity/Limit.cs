namespace CostEffectiveLoadBalancer.Domain.Entity
{
    using System.ComponentModel.DataAnnotations;
    
    public class Limit
    {
        public int Id { get; set; }

        [Required]
        public int ResourceTypeId { get; set; }

        [Required]
        public int LimitTypeId { get; set; }

        [Required]
        public int Value { get; set; }

        public virtual ResourceType ResourceType { get; set; }

        public virtual LimitType LimitType { get; set;}
    }
}