using System;
using Vehicles.Exeptions;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public class Vehicle : IVehicle
    {
        private double fuel;
        public Vehicle(string type, double fuel, double fuelConsumption, double thankCapacity)
        {
            Type = type;
            Fuel = fuel > thankCapacity ? 0 : fuel;
            FuelConsumption = fuelConsumption;
            ThankCapacity = thankCapacity;
        }
        public string Type { get; protected set; }

        public virtual bool IsEmpty { get; set; }
        public double Fuel { get; set; }
      
        public virtual double FuelConsumption { get; protected set; }

        public double ThankCapacity { get; protected set; }

        public void Drive(double distance)
        {
            if (this.Fuel - this.FuelConsumption * distance >= 0)
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
            if (litres <= 0)
            {
                throw new ArgumentException(string.Format(ExceptionMessage.FuelCannotBeAZero));
            }

            if (this.Fuel + litres <= this.ThankCapacity)
            {
                return Fuel += litres;
            }

            throw new ArgumentException(string.Format(ExceptionMessage.CanNotFitFuel, litres));


        }
    }
}
