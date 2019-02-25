namespace CostEffectiveLoadBalancer.Domain.Entity
{
    public class Application
    {        
        public int Id { get; set; }

        [Required(), MaxLength(45)]
        public string Name { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }
    }
}