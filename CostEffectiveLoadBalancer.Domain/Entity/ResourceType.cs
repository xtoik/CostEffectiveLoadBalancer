namespace CostEffectiveLoadBalancer.Domain.Entity
{
    public class ResourceType
    {
        public int Id { get; set; }

        [Required()]
        public int ProviderId { get; set; }

        [Required(), MaxLength(45)]
        public string Name { get; set; }

        public virtual Provider Provider { get; set; }
    }
}