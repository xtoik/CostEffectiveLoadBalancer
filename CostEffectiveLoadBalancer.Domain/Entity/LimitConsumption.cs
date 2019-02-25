namespace CostEffectiveLoadBalancer.Domain.Entity
{
    public class LimitConsumption
    {
        public int Id { get; set; }

        [Required()]
        public int LimitId { get; set; }

        [Required()]
        public DateTime PeriodStart { get; set; }

        [Required()]
        public DateTime PeriodEnd { get; set; }

        [Required()]
        public int Value { get; set; }
    }
}