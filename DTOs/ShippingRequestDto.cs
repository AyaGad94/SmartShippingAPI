namespace SmartShippingAPI.DTOs
{
    public class ShippingRequestDto
    {
        public double Weight { get; set; }
        public string Destination { get; set; } = string.Empty;
        public string ShippingMethod { get; set; } = string.Empty;
    }
}
