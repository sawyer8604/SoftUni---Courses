using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        string make;
        string model;
        int year;
        double fuelQuantity;
        double fuelConsumption;


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }


        public void Drive(double distance)
        {
            if (FuelQuantity - distance * FuelConsumption / 100 > 0)
            {
                FuelQuantity -= distance * FuelConsumption / 100;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:f2}";
        }
    }
}
