namespace SmartShippingAPI.Services.ShippingStrategies
{
    public interface IShippingStrategy
    {
        double Calculate(double weight, string destination);
    }
}
