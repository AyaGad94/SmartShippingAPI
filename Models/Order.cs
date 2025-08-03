using System;

namespace SmartShippingAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public decimal Weight { get; set; }
        public string Destination { get; set; }
        public bool IsVipCustomer { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public decimal ShippingCost { get; set; }
        public string StrategyUsed { get; set; }
    }
}
