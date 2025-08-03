using Microsoft.AspNetCore.Mvc;
using SmartShippingAPI.Data;
using SmartShippingAPI.Models;
using SmartShippingAPI.Services;
using System;

namespace SmartShippingAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShippingController : ControllerBase
    {
        private readonly ShippingCostCalculator _calculator;
        private readonly AppDbContext _context;

        public ShippingController(ShippingCostCalculator calculator, AppDbContext context)
        {
            _calculator = calculator;
            _context = context;
        }

        [HttpPost("calculate")]
        public IActionResult CalculateShipping([FromBody] OrderDto orderDto)
        {
            try
            {
                var cost = _calculator.CalculateShippingCost(orderDto.ShippingMethod, orderDto.Weight, orderDto.Destination);

                var order = new Order
                {
                    Destination = orderDto.Destination,
                    Weight = orderDto.Weight,
                    ShippingCost = cost,
                    StrategyUsed = orderDto.ShippingMethod,
                    CreatedAt = DateTime.UtcNow,
                    IsVipCustomer = false // or set via logic if needed
                };

                _context.Orders.Add(order);
                _context.SaveChanges();

                return Ok(new { cost });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { Message = ex.Message });
            }
        }
    }
}
