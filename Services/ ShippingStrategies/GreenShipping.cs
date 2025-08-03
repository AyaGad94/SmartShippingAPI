namespace SmartShippingAPI.Services.ShippingStrategies
{
    public class GreenShipping : IShippingStrategy
    {
        public double Calculate(double weight, string destination)
        {
            return weight * 1.8 + 8;
        }
    }
}
