using System;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Vehicle : IVehicle
    {
        public Vehicle(string type, double fuel, double fuelConsumption)
        {
            Type = type;
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
        }

        public string Type { get; protected set; }

        public double Fuel { get; protected set; }

        public virtual double FuelConsumption { get; protected set; }

        public void Drive(double distance)
        {
            if(this.Fuel - this.FuelConsumption * distance >= 0)
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                this.Fuel -= this.FuelConsumption * distance;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
        public virtual double Refuel(double litres)
        {
            return Fuel += litres;
        }
    }
}
