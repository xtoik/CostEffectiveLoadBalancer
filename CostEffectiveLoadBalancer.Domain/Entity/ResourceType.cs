namespace CostEffectiveLoadBalancer.Domain.Entity
{
    using System.ComponentModel.DataAnnotations;
    
    public class ResourceType
    {
        public int Id { get; set; }

        [Required]
        public int ProviderId { get; set; }

        [Required, StringLength(45)]
        public string Name { get; set; }

        public virtual Provider Provider { get; set; }
    }
}