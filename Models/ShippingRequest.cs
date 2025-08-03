namespace SmartShippingAPI.Models
{
    public class ShippingRequest
    {
        public double Weight { get; set; }

        public required string Destination { get; set; }

        public required string ShippingMethod { get; set; }
    }
}
