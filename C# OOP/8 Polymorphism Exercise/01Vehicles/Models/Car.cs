using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private double fuelConsumpionWithAirConditioner = 0.9;
        public Car(string type, double fuel, double fuelConsumption)
            : base(type, fuel, fuelConsumption )
        {
        }

        public override double FuelConsumption 
        { get => base.FuelConsumption; protected set => base.FuelConsumption = value + fuelConsumpionWithAirConditioner; }

    }
}
