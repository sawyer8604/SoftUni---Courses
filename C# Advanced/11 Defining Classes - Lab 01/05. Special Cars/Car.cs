using System;

using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private Engine engine;
        private Tire[] tires;

        public Engine Engine
        {
            get { return this.engine; }
             set { this.engine = value; }
        }

        public Tire[] Tires
        {
            get { return this.tires; }
             set { this.tires = value; }
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {

            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }


        public void Drive(double distance)
        {
            double fuelToConsume = (distance / 100) * FuelConsumption;

            if (FuelQuantity - fuelToConsume > 0)
            {
                FuelQuantity -= fuelToConsume;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }

        }

        public string WhoAmI()
        {

            return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}L";
        }
    }
}