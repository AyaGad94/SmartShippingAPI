namespace SmartShippingAPI.Models
{
    public class OrderDto
    {
        public string Destination { get; set; }
        public decimal Weight { get; set; }
        public string ShippingMethod { get; set; }
    }
}
