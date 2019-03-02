namespace CostEffectiveLoadBalancer.Domain.Entity
{
    using System.ComponentModel.DataAnnotations;

    public class Endpoint
    {
        public int Id { get; set; }

        [Required]
        public int ApplicationId { get; set; }

        [Required, StringLength(45)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public virtual Application Application { get; set; }
    }
}