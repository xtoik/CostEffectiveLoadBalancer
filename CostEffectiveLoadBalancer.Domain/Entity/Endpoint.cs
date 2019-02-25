namespace CostEffectiveLoadBalancer.Domain.Entity
{
    public class Endpoint
    {
        public int Id { get; set; }

        [Required()]
        public int ApplicationId { get; set; }

        [Required(), MaxLength(45)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public virtual Application Application { get; set; }
    }
}