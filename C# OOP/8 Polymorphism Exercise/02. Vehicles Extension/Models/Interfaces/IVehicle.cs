namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        public string Type { get;}
        public double Fuel { get; }
        public double FuelConsumption { get; }
        public double ThankCapacity { get; }
        public bool IsEmpty { get; set; }

        public void Drive(double distance);

        public double Refuel(double litres);
    }
}
