using AutoMapper;
using CarDealer.Data;
using CarDealer.DataTransferOject.InputModels;
using CarDealer.DataTransferOject.OutputModels;
using CarDealer.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using XmlFacade;

namespace CarDealer
{
    public class StartUp
    {
       
        public static void Main(string[] args)
        {
            CarDealerContext context = new CarDealerContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //var supplierXml = File.ReadAllText("./Datasets/suppliers.xml");

            //var partsXml = File.ReadAllText("./Datasets/parts.xml");

            //var carssXml = File.ReadAllText("./Datasets/cars.xml");

            //var supplierResult = ImportSuppliers(context, supplierXml);

            //var partsResult = ImportParts(context, partsXml);

            //var carsResult = ImportCars(context, carssXml);

            //Console.WriteLine(carsResult);

            Console.WriteLine(GetCarsWithDistance(context));
        }
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            const string root = "Suppliers";
            // FIRST WAY
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(SupplierInputModel[]), new XmlRootAttribute(root));

            //var textReader = new StringReader(inputXml);

            //var suppliersDto = xmlSerializer.Deserialize(textReader) as SupplierInputModel[];

            // SECOND WAY

            var suppliersDto = XmlConverter.Deserializer<SupplierInputModel>(inputXml, root);


            var suppliers = suppliersDto.Select(x => new Supplier
            {
                Name = x.Name,
                IsImporter = x.IsImporter
            })
                .ToList();

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();


            return $"Successfully imported {suppliers.Count()}"; ;
        }        

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            const string root = "Parts";

            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(PartsInputModel[]), new XmlRootAttribute(root));

            //var textReader = new StringReader(inputXml);

            //var partsDto = xmlSerializer.Deserialize(textReader) as PartsInputModel[];

            // SECOND WAY

            var partsDto = XmlConverter.Deserializer<PartsInputModel>(inputXml, root);
            var suppliersIds = context.Suppliers
                .Select(x => x.Id)
                .ToList();

            var parts = partsDto
                .Where(s => suppliersIds.Contains(s.SupplierId))
                .Select(x => new Part
            {
                Name = x.Name,
                Price = x.Price,
                Quantity = x.Quantity,
                SupplierId = x.SupplierId,
            })
                .ToList();

            context.Parts.AddRange(parts);
            context.SaveChanges();


            return $"Successfully imported {parts.Count()}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            const string root = "Cars";

            var cars = new List<Car>();

            var carsDtos = XmlConverter.Deserializer<CarInputModel>(inputXml, root);

            var allParts = context.Parts.Select(x => x.Id).ToList();

            foreach (var currentCar in carsDtos)
            {
                var distinctedParts = currentCar.CarPartsInputModel.Select(x => x.Id).Distinct();
                var parts = distinctedParts.Intersect(allParts);

                var car = new Car
                {
                    Make = currentCar.Make,
                    Model = currentCar.Model,
                    TravelledDistance = currentCar.TravelledDistance
                };

                foreach (var part in parts)
                {
                    var partCar = new PartCar
                    {
                        PartId = part
                    };

                    car.PartCars.Add(partCar);
                }

                cars.Add(car);

            }
            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }

        //Export 

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(x => x.TravelledDistance > 2_000_000)
                .Select(c => new CarOutputModel
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .OrderBy(x => x.Make)
                .ThenBy(x => x.Model)
                .Take(10)
                .ToArray();

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CarOutputModel[]), new XmlRootAttribute("cars"));
            
            var textWriter = new StringWriter();

            var ns = new XmlSerializerNamespaces();
            ns.Add("", "");

            xmlSerializer.Serialize(textWriter, cars, ns);

            var result = textWriter.ToString();

            return result;

        }


    }
}