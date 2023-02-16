namespace Vehicles.Core
{
    using Core.Interfaces;
    using IO.Interfaces;
    using Models;
    using Models.Interfaces;
    using System;

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
            string[] carInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string type = carInfo[0];
            double fuel = double.Parse(carInfo[1]);
            double fuelConsumption = double.Parse(carInfo[2]);
            double capacity = double.Parse(carInfo[3]);

            IVehicle car = new Car(type, fuel, fuelConsumption, capacity);

            string[] truckInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string truckType = truckInfo[0];
            double truckFuel = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckCapacity = double.Parse(truckInfo[3]);

            IVehicle truck = new Truck(truckType, truckFuel, truckFuelConsumption, truckCapacity);

            string[] buskInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string buskType = buskInfo[0];
            double buskFuel = double.Parse(buskInfo[1]);
            double busFuelConsumption = double.Parse(buskInfo[2]);
            double busCapacity = double.Parse(buskInfo[3]);

            IVehicle bus = new Bus(buskType, buskFuel, busFuelConsumption, busCapacity);

            int numberOfCommands = int.Parse(reader.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                try
                {
                    string[] commands = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string firstCommand = commands[0];

                    if (firstCommand == "Drive")
                    {
                        string vehicleType = commands[1];
                        double distance = double.Parse(commands[2]);

                        if (vehicleType == "Car")
                        {
                            car.Drive(distance);
                        }
                        else if(vehicleType == "Bus")
                        {
                            bus.Drive(distance);
                        }
                        else
                        {
                            truck.Drive(distance);
                        }
                    }
                    else if (firstCommand == "Refuel")
                    {
                        string vehicleType = commands[1];
                        double fuels = double.Parse(commands[2]);

                        if (vehicleType == "Car")
                        {
                            car.Refuel(fuels);
                        }
                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(fuels);
                        }
                        else
                        {
                            truck.Refuel(fuels);
                        }
                    }
                    else if(firstCommand == "DriveEmpty")
                    {
                        bus.IsEmpty= true;
                        double distance = double.Parse(commands[2]);
                        bus.Drive(distance);
                        bus.IsEmpty = false;
                    }
                }
                catch (System.Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            writer.WriteLine($"Car: {car.Fuel:f2}");
            writer.WriteLine($"Truck: {truck.Fuel:f2}");
            writer.WriteLine($"Bus: {bus.Fuel:f2}");

        }
    }
}
