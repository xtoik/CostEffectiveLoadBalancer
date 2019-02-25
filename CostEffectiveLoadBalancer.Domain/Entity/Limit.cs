namespace CostEffectiveLoadBalancer.Domain.Entity
{
    public class Limit
    {
        public int Id { get; set; }

        [Required()]
        public int ResourceTypeId { get; set; }

        [Required(), MaxLength(10)]
        public string LimitType { get; set; }

        [Required]
        public int Value { get; set; }

        public ResourceType ResourceType { get; set; }
    }
}