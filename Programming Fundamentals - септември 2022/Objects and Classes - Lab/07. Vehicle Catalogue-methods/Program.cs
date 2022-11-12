using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Catalog catalog = new Catalog();

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split("/");

                string type = arguments[0];
                string brand = arguments[1];
                string model = arguments[2];
                int horesePowerOrWeight = int.Parse(arguments[3]);

                if (type == "Truck")
                {
                    Trucks trucks = new Trucks(brand, model, horesePowerOrWeight);
                    catalog.Trucks.Add(trucks);

                }
                else
                {
                    Cars cars = new Cars(brand, model, horesePowerOrWeight);
                    catalog.Cars.Add(cars);
                }
            }
            PrintCars(catalog);

            PrintTrucks(catalog);
        }

        static void PrintCars(Catalog catalog)
        {
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Cars car in catalog.Cars.OrderBy(b => b.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
        }

        static void PrintTrucks(Catalog catalog)
        {
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Trucks truck in catalog.Trucks.OrderBy(b => b.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weigh}kg");
                }
            }
        }
    }

    public class Trucks
    {
        public Trucks(string brand, string model, int weigh)
        {
            Brand = brand;
            Model = model;
            Weigh = weigh;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weigh { get; set; }


    }

    public class Cars
    {
        public Cars(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            Trucks = new List<Trucks>();
            Cars = new List<Cars>();
        }

        public List<Trucks> Trucks { get; set; }
        public List<Cars> Cars { get; set; }
    }
}
