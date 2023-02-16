namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private double fuelConsumpionWithAirConditioner = 1.6;

        public Truck(string type, double fuel, double fuelConsumption, double thankCapacity)
            : base(type, fuel, fuelConsumption, thankCapacity)
        {
        }

        public override double FuelConsumption
        { get => base.FuelConsumption; protected set => base.FuelConsumption = value + fuelConsumpionWithAirConditioner; }

        public override double Refuel(double litres)
        {

            if (this.Fuel + litres <= this.ThankCapacity)
            {
                return base.Refuel(litres * 0.95);
            }
            return base.Refuel(litres);
        }
    }
}
