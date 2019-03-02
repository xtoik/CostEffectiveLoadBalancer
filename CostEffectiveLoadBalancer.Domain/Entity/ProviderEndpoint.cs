namespace CostEffectiveLoadBalancer.Domain.Entity
{
    using System.ComponentModel.DataAnnotations;
    
    public class ProviderEndpoint
    {
        public int Id { get; set; }

        [Required]
        public int ResourceTypeId { get; set; }

        [Required]
        public int EndpointId { get; set; }

        [Required, StringLength(2000)]
        public string Url { get; set; }

        public virtual ResourceType ResourceType { get; set; }

        public virtual Endpoint Endpoint { get; set; }        
    }
}