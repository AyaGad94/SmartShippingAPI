using SmartShippingAPI.Services.ShippingStrategies;
using System;
using System.Collections.Generic;

namespace SmartShippingAPI.Services
{
    public class ShippingCostCalculator
    {
        private readonly Dictionary<string, IShippingStrategy> _strategies;

        public ShippingCostCalculator()
        {
            _strategies = new Dictionary<string, IShippingStrategy>
            {
                { "fastest", new FastestShipping() },
                { "cheapest", new CheapestShipping() },
                { "green", new GreenShipping() }
            };
        }

        public decimal CalculateShippingCost(string method, decimal weight, string destination)
        {
            if (_strategies.TryGetValue(method.ToLower(), out var strategy))
            {
                return (decimal)strategy.Calculate((double)weight, destination);
            }

            throw new ArgumentException($"Shipping method '{method}' is not supported.");
        }
    }
}
