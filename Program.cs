using Microsoft.EntityFrameworkCore;
using SmartShippingAPI.Data;
using SmartShippingAPI.Services;
using SmartShippingAPI.Services.ShippingStrategies;

var builder = WebApplication.CreateBuilder(args);

// Register DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddSingleton<ShippingCostCalculator>();
// Register Services
builder.Services.AddScoped<ShippingCostCalculator>();

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSingleton<ShippingCostCalculator>();

builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
