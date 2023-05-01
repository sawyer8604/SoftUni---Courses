using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Castle.Core.Resource;
using Newtonsoft.Json;

namespace CarDealer
{
    
    public class StartUp
    {
        static IMapper mapper;
        public static void Main(string[] args)
        {
            var carDealerContext = new CarDealerContext();
            carDealerContext.Database.EnsureDeleted();
            carDealerContext.Database.EnsureCreated();

            var inputJsonSupplier = File.ReadAllText("../../../Datasets/suppliers.json");

            var inputJsonParts = File.ReadAllText("../../../Datasets/parts.json");

            var inputJsonCars = File.ReadAllText("../../../Datasets/cars.json");

            var inputJsonCustomers = File.ReadAllText("../../../Datasets/customers.json");

            var inputJsonSales = File.ReadAllText("../../../Datasets/sales.json");


            var resultSuppliers = ImportSuppliers(carDealerContext, inputJsonSupplier);

            var resultParts = ImportParts(carDealerContext, inputJsonParts);

            var resultCars = ImportCars(carDealerContext, inputJsonCars);

            var resultCustomers = ImportCustomers(carDealerContext, inputJsonCustomers);

            var resultSales = ImportSales(carDealerContext, inputJsonSales);

            Console.WriteLine(resultSales);
        }

        private static void InitializeMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CarDealerProfile>();
            });

            mapper = config.CreateMapper();
        }

        //09. Import Suppliers
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            InitializeMapper();

            var dtoSuppliers = JsonConvert.DeserializeObject<IEnumerable<SuppliersInputModel>>(inputJson);

            var suppliers = mapper.Map<IEnumerable<Supplier>>(dtoSuppliers);

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count()}.";
        }

        // 10. Import Parts

        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            InitializeMapper();

            List<int> supplierListIds = context.Suppliers
            .Select(s => s.Id)
            .ToList();

            var dtoParts = JsonConvert.DeserializeObject<IEnumerable<PartsInputModel>>(inputJson)
                .Where(p => supplierListIds.Contains(p.SupplierId));

            var parts = mapper.Map<IEnumerable<Part>>(dtoParts);

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count()}.";
        }

        //11. Import Cars
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            List<CarsInputModel> carsDtos = JsonConvert.DeserializeObject<List<CarsInputModel>>(inputJson);

            List<Car> cars = new List<Car>();
            List<PartCar> parts = new List<PartCar>();

            foreach (var carDto in carsDtos)
            {
                Car car = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledDistance = carDto.TravelledDistance
                };

                cars.Add(car);

                foreach (var carPart in carDto.PartsId.Distinct())
                {
                    PartCar partCar = new PartCar()
                    {
                        Car = car,
                        PartId = carPart
                    };

                    parts.Add(partCar);
                }
            }

            context.AddRange(cars);
            context.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}.";
        }

        //12. Import Customers
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            InitializeMapper();

            var dtoCustomers = JsonConvert.DeserializeObject<IEnumerable<CustomerInputModel>>(inputJson);

            var customers = mapper.Map<IEnumerable<Customer>>(dtoCustomers);

            context.Customers.AddRange(customers);
            context.SaveChanges();


            return $"Successfully imported {customers.Count()}.";

        }

        // 13. Import Sales

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            InitializeMapper();

            var dtoSales = JsonConvert.DeserializeObject<IEnumerable<SalesInputModel>>(inputJson);

            var sales = mapper.Map<IEnumerable<Sale>>(dtoSales);

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count()}.";
        }
    }
}