namespace Vehicles.Core
{
    using Core.Interfaces;
    using IO.Interfaces;
    using Models;
    using Models.Interfaces;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IReader reader, IWriter writer)
           
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string[] carInfo = reader.ReadLine().Split(" ");

            string type = carInfo[0];
            double fuel = double.Parse(carInfo[1]);
            double fuelConsumption = double.Parse(carInfo[2]);

            IVehicle car = new Car(type, fuel, fuelConsumption);

            string[] truckInfo = reader.ReadLine().Split(" ");

            string truckType = truckInfo[0];
            double truckFuel = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);

            IVehicle truck = new Truck(truckType, truckFuel, truckFuelConsumption);

            int numberOfCommands = int.Parse(reader.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = reader.ReadLine().Split(" ");
                string firstCommand = commands[0];

                if(firstCommand == "Drive")
                {
                    string vehicleType = commands[1];
                    double distance = double.Parse(commands[2]);

                    if(vehicleType == "Car")
                    {
                        car.Drive(distance);
                    }
                    else
                    {
                        truck.Drive(distance);
                    }
                }
                else if (firstCommand == "Refuel")
                {
                    string vehicleType = commands[1];
                    double distance = double.Parse(commands[2]);

                    if (vehicleType == "Car")
                    {
                        car.Refuel(distance);
                    }
                    else
                    {
                        truck.Refuel(distance);
                    }
                }

            }

            writer.WriteLine($"Car: {car.Fuel:f2}");
            writer.WriteLine($"Truck: {truck.Fuel:f2}");

        }
    }
}
