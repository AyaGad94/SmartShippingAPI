# SmartShippingAPI

A modular ASP.NET Core Web API that calculates shipping costs using different strategies such as **Fastest**, **Cheapest**, and **Green**.  
This project demonstrates the **Strategy Design Pattern** and clean separation of concerns with service-layer architecture.

## 🚀 Overview

The SmartShippingAPI allows users to create shipping orders and automatically calculates the shipping cost based on a selected strategy.  
You can easily extend or swap out strategies without modifying the core logic – a textbook example of the Strategy Design Pattern in action.

## 🧠 Design Pattern Used

- ✅ **Strategy Design Pattern** – Encapsulates multiple shipping cost calculation strategies.

## ⚙️ Features

- Add a new shipping order with custom input.
- Calculates shipping cost based on:
  - `FastestShipping`
  - `CheapestShipping`
  - `GreenShipping`
- Stores the result including strategy used.
- Fully testable and extendable service structure.

## 📁 Project Structure

- **Controllers/** – Exposes HTTP endpoints.
- **Services/**
  - **ShippingStrategies/** – Contains all strategy classes implementing `IShippingStrategy`.
  - `ShippingCostCalculator.cs` – Applies the selected strategy.
- **DTOs/** – Data transfer objects for input/output.
- **Profiles/** – AutoMapper configuration.
- **Data/** – EF Core context and migrations.
- **Models/** – Entity classes like `Order`.

## 🛠️ Tech Stack

- ASP.NET Core Web API (.NET 6+)
- Entity Framework Core
- SQL Server (SSMS)
- AutoMapper
- Strategy Pattern (custom implementation)
- Swagger for API testing

## 📌 How to Run

### 1. Clone the Repository
```bash
git clone https://github.com/YourUsername/SmartShippingAPI.git
cd SmartShippingAPI
