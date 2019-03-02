namespace CostEffectiveLoadBalancer.Domain.Entity
{
    using System.ComponentModel.DataAnnotations;

    public class LimitType
    {
        public int Id { get; set; }

        [Required, StringLength(45)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}