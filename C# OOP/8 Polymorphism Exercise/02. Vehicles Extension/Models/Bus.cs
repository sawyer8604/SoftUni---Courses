using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private double fuelConsumpionWithAirConditioner = 1.4;
        
        public Bus(string type, double fuel, double fuelConsumption, double thankCapacity)
            : base(type, fuel, fuelConsumption, thankCapacity)
        {
        }

        public override double FuelConsumption
        => this.IsEmpty
            ? base.FuelConsumption
            : base.FuelConsumption + fuelConsumpionWithAirConditioner;


    }
}
