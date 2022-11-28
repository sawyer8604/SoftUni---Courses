using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III_Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, Mileage> cars = new Dictionary<string, Mileage>();

            //{car}|{mileage}|{fuel}

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] carsInformation = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string carName = carsInformation[0];
                int kilometres = int.Parse(carsInformation[1]);
                int fuel = int.Parse(carsInformation[2]);

                if (!cars.ContainsKey(carName))
                {
                    cars[carName] = new Mileage(kilometres, fuel);
                }
                cars[carName].distance = kilometres;
                cars[carName].fuel = fuel;

            }


            string commands;

            while ((commands = Console.ReadLine()) != "Stop")
            {
                string[] cmdArguments = commands.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Drive":

                        string car = cmdArguments[1];
                        int distance = int.Parse(cmdArguments[2]);
                        int fuel = int.Parse(cmdArguments[3]);

                        DriveTheCar(cars, car, distance, fuel);

                        break;

                    case "Refuel":

                        string refuelCar = cmdArguments[1];
                        int fuelRefuel = int.Parse(cmdArguments[2]);

                        RefuelTheFuel(cars, refuelCar, fuelRefuel);

                        break;

                    case "Revert":

                        string carRevert = cmdArguments[1];
                        int kilometresForRevert = int.Parse(cmdArguments[2]);

                        RevertTheKilometres(cars, carRevert, kilometresForRevert);

                        break;

                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.distance} kms, Fuel in the tank: {car.Value.fuel} lt.");
            }
        }       

        static void DriveTheCar(Dictionary<string, Mileage> cars, string car, int distance, int fuel)
        {
            if (cars.ContainsKey(car))
            {
                if (cars[car].fuel - fuel >= 0)
                {
                    cars[car].distance += distance;
                    cars[car].fuel -= fuel;

                    Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                    if (cars[car].distance >= 100_000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        cars.Remove(car);
                    }
                }
                else
                {
                    Console.WriteLine("Not enough fuel to make that ride");
                }

            }
        }

        static void RefuelTheFuel(Dictionary<string, Mileage> cars, string refuelCar, int fuelRefuel)
        {
            if (cars.ContainsKey(refuelCar))
            {

                if (cars[refuelCar].fuel + fuelRefuel <= 75)
                {
                    cars[refuelCar].fuel += fuelRefuel;

                    Console.WriteLine($"{refuelCar} refueled with {fuelRefuel} liters");
                }
                else
                {
                    int crrFuel = 75 - cars[refuelCar].fuel;
                    cars[refuelCar].fuel = 75;
                    Console.WriteLine($"{refuelCar} refueled with {crrFuel} liters");
                }
            }
        }

        static void RevertTheKilometres(Dictionary<string, Mileage> cars, string carRevert, int kilometresForRevert)
        {
            if (cars.ContainsKey(carRevert))
            {
                cars[carRevert].distance -= kilometresForRevert;

                if (cars[carRevert].distance < 10_000)
                {
                    cars[carRevert].distance = 10_000;
                }
                else
                {
                    Console.WriteLine($"{carRevert} mileage decreased by {kilometresForRevert} kilometers");
                }

            }
        }
        public class Mileage
        {
            public Mileage(int distance, int fuel)
            {
                this.distance = distance;
                this.fuel = fuel;
            }

            public int distance { get; set; }
            public int fuel { get; set; }
        }
    }
}
