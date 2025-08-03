namespace SmartShippingAPI.Services.ShippingStrategies
{
    public class CheapestShipping : IShippingStrategy
    {
        public double Calculate(double weight, string destination)
        {
            return weight * 1.5 + 5;
        }
    }
}
