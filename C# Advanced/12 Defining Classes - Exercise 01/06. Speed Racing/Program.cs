using System;
using System.Collections.Generic;

namespace _06._Speed_Racing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> allCars = new Dictionary<string, Car>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsumptionFor1km = double.Parse(carInfo[2]);
                double travelledDistance = 0;

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km, travelledDistance);

                allCars[model] = car;

            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = cmdArguments[1];
                double distanceTraveled = double.Parse(cmdArguments[2]);

                allCars[model].Drive(model, distanceTraveled);
            }

            //{model} {fuelAmount} {distanceTraveled}

            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }
        }
    }
}
