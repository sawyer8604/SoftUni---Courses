using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Castle.Core.Resource;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CarDealer
{
    
    public class StartUp
    {
        static IMapper mapper;
        public static void Main(string[] args)
        {
            var carDealerContext = new CarDealerContext();
            

            // provlem 14

            Console.WriteLine(GetOrderedCustomers(carDealerContext));
            File.WriteAllText(@"../../../Results/ordered-customers.json", GetOrderedCustomers(carDealerContext));


            // problem 15

            Console.WriteLine(GetCarsFromMakeToyota(carDealerContext));
            File.WriteAllText(@"../../../Results/toyota-cars.json", GetCarsFromMakeToyota(carDealerContext));

            // problem 16

            Console.WriteLine(GetLocalSuppliers(carDealerContext));
            File.WriteAllText(@"../../../Results/local-suppliers.json", GetLocalSuppliers(carDealerContext));

            // problem 17

            Console.WriteLine(GetCarsWithTheirListOfParts(carDealerContext));
            File.WriteAllText(@"../../../Results/cars-and-parts.json", GetCarsWithTheirListOfParts(carDealerContext));

            // problem 18

            Console.WriteLine(GetTotalSalesByCustomer(carDealerContext));
            File.WriteAllText(@"../../../Results/customers-total-sales.json", GetTotalSalesByCustomer(carDealerContext));

            // problem 19
            Console.WriteLine(GetSalesWithAppliedDiscount(carDealerContext));

            File.WriteAllText(@"../../../Results/sales-discounts.json", GetSalesWithAppliedDiscount(carDealerContext));
        }

        private static void InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarDealerProfile>();
            });

            mapper = config.CreateMapper();
        }

        

        // 14. Export Ordered Customers

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(x => x.BirthDate)
                .ThenBy(x => x.IsYoungDriver)
                .Select(x => new
                {
                    Name = x.Name,
                    BirthDate = x.BirthDate.ToString("dd/MM/yyyy"),
                    IsYoungDriver = x.IsYoungDriver
                })
                .ToList();

            var result = JsonConvert.SerializeObject(customers, Formatting.Indented);

            return result; 
        }

        // 15. Export Cars from Make Toyota       
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var carsToyota = context.Cars
                .Where(c => c.Make == "Toyota")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .Select(c => new
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TravelledDistance,
                })
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(carsToyota, Formatting.Indented);
        }

        // 16. Export Local Suppliers
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var localSuppliers = context.Suppliers
                .Where(s => !s.IsImporter)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = context.Parts
                        .Count(p => p.SupplierId == s.Id)
                })
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(localSuppliers, Formatting.Indented);
        }

        // 17. Export Cars with Their List of Parts       
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var carsWithParts = context.Cars
                .Select(c => new
                {
                    car = new
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TraveledDistance = c.TravelledDistance
                    },
                    parts = c.PartCars.Select(p => new
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price.ToString("0.00"),
                    })
                })
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(carsWithParts, Formatting.Indented);
        }

        // 18. Export Total Sales by Customer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .Where(cus => cus.Sales.Any())
                .Select(cus => new
                {
                    fullName = cus.Name,
                    boughtCars = cus.Sales.Count(),
                    moneyCars = cus.Sales
                        .SelectMany(c => c.Car.PartCars.Select(p => p.Part.Price))
                })
                .AsNoTracking()
                .ToArray();

            var output = customers
                .Select(o => new
                {
                    o.fullName,
                    o.boughtCars,
                    spentMoney = o.moneyCars.Sum()
                })
                .OrderByDescending(o => o.spentMoney)
                .ThenByDescending(o => o.boughtCars)
                .ToArray();

            return JsonConvert.SerializeObject(output, Formatting.Indented);
        }

        // 19. Export Sales with Applied Discount
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Take(10)
                .Select(s => new
                {
                    car = new
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TravelledDistance,
                    },

                    customerName = s.Customer.Name,
                    discount = s.Discount.ToString("0.00"),
                    price = s.Car.PartCars.Sum(p => p.Part.Price).ToString("0.00"),
                    priceWithDiscount = (s.Car.PartCars.Sum(p => p.Part.Price) * (1 - (s.Discount / 100))).ToString("0.00")
                })
                .AsNoTracking()
                .ToArray();

            return JsonConvert.SerializeObject(sales, Formatting.Indented);
        }
    }
}