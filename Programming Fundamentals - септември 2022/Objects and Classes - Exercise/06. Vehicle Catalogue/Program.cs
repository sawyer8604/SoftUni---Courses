using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string input;
            double carSum = 0;
            double truckSum = 0;
            double avarageCars = 0.00;
            double avarageTrucks = 0.00;

            string type;
            string model;
            string color;
            int horsePower = 0;

            List<Vehicle> cars = new List<Vehicle>();

            List<Vehicle> trucks = new List<Vehicle>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                type = arguments[0];
                model = arguments[1];
                color = arguments[2];
                horsePower = int.Parse(arguments[3]);

                Vehicle catalog = new Vehicle(type, model, color, horsePower);


                if (type == "car")
                {
                    cars.Add(catalog);

                    carSum += horsePower;

                }
                else if (type == "truck")
                {

                    trucks.Add(catalog);
                    truckSum += horsePower;

                }

            }
           

            string vehicle;

            while ((vehicle = Console.ReadLine()) != "Close the Catalogue")
            {


                foreach (Vehicle car in cars)
                {

                    if (vehicle == car.Model)
                    {
                        car.Type = "Car";

                        Console.WriteLine($"Type: {car.Type}");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.Horsepower}");

                    }

                }



                foreach (Vehicle truck in trucks)
                {

                    if (vehicle == truck.Model)
                    {
                        truck.Type = "Truck";

                        Console.WriteLine($"Type: {truck.Type}");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.Horsepower}");

                    }

                }

            }
            avarageCars = carSum / cars.Count;
            avarageTrucks = truckSum / trucks.Count;

           
           

            if (avarageCars != 0 && cars.Count > 0)
            {
                type = "Cars";

                Console.WriteLine($"{type} have average horsepower of: {avarageCars:f2}.");
            }
            else
            {
                avarageCars = 0.00;
                Console.WriteLine($"Cars have average horsepower of: {avarageCars:f2}.");
            }

            if (avarageTrucks != 0 && trucks.Count > 0)
            {
                type = "Trucks";
                Console.WriteLine($"{type} have average horsepower of: {avarageTrucks:f2}.");
            }
            else
            {
                avarageTrucks = 0.00;
                type = "Trucks";
                Console.WriteLine($"{type} have average horsepower of: {avarageTrucks:f2}.");

            }


        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }


    }

}
