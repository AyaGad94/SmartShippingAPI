namespace SmartShippingAPI.Services.ShippingStrategies
{
    public class FastestShipping : IShippingStrategy
    {
        public double Calculate(double weight, string destination)
        {
            return weight * 2.5 + 10;
        }
    }
}
