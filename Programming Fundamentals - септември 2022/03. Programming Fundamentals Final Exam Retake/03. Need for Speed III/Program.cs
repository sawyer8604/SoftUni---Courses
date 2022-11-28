using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            //{car}|{mileage}|{fuel}

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] carsInformation = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);

                string carName = carsInformation[0];
                int kilometres = int.Parse(carsInformation[1]);
                int fuel = int.Parse(carsInformation[2]);

                if(!cars.ContainsKey(carName))
                {
                    cars[carName] = new List<int>() { 0, 0 };
                }
                cars[carName][0] = kilometres;
                cars[carName][1] = fuel;

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

                        if(cars.ContainsKey(car))
                        {
                            if(cars[car][1] - fuel >= 0)
                            {
                                cars[car][0] += distance;
                                cars[car][1] -= fuel;

                                Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                                if(cars[car][0] >= 100_000)
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

                        break;

                    case "Refuel":

                        string refuelCar = cmdArguments[1];
                        int fuelRefuel = int.Parse(cmdArguments[2]);

                        if(cars.ContainsKey(refuelCar))
                        {                            

                            if(cars[refuelCar][1] + fuelRefuel <= 75)
                            {
                                cars[refuelCar][1] += fuelRefuel;

                                Console.WriteLine($"{refuelCar} refueled with {fuelRefuel} liters");
                            }
                            else
                            {
                                int crrFuel = 75 - cars[refuelCar][1];
                                cars[refuelCar][1] = 75;
                                Console.WriteLine($"{refuelCar} refueled with {crrFuel} liters");
                            }
                        }

                        break;

                    case "Revert":

                        string carRevert = cmdArguments[1];
                        int kilometresForRevert = int.Parse(cmdArguments[2]);

                        if(cars.ContainsKey(carRevert))
                        {
                            cars[carRevert][0] -= kilometresForRevert;                            

                            if(cars[carRevert][0] < 10_000)
                            {
                                cars[carRevert][0] = 10_000;
                            }
                            else
                            {
                                Console.WriteLine($"{carRevert} mileage decreased by {kilometresForRevert} kilometers");
                            }

                        }

                        break;

                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }

        }
    }
}
