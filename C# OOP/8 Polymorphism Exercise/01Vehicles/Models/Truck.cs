namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private double fuelConsumpionWithAirConditioner = 1.6;
        public Truck(string type, double fuel, double fuelConsumption)
            : base(type, fuel, fuelConsumption)
        {
        }
        public override double FuelConsumption
        { get => base.FuelConsumption; protected set => base.FuelConsumption = value + fuelConsumpionWithAirConditioner; }

        public override double Refuel(double litres)
        {
            return base.Refuel(litres * 0.95);
        }
    }
}
