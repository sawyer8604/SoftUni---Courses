using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tireList = new List<Tire[]>();
            string command;

            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    
                int firstYear = int.Parse(cmdArguments[0]);
                double firstPressure = double.Parse(cmdArguments[1]);
                int secondYear = int.Parse(cmdArguments[2]);
                double secondPressure = double.Parse(cmdArguments[3]);
                int thirdYear = int.Parse(cmdArguments[4]);
                double thirdPressure = double.Parse(cmdArguments[5]);
                int fourthYear = int.Parse(cmdArguments[6]);
                double fourthPressure = double.Parse(cmdArguments[7]);

                Tire[] tires = new Tire[4]
                {
                new Tire (firstYear, firstPressure),
                new Tire (secondYear, secondPressure),
                new Tire (thirdYear, thirdPressure),
                new Tire (fourthYear, fourthPressure),

                };
                tireList.Add(tires);

            }

            List<Engine> engineList = new List<Engine>();
            string secondCommand;

            while ((secondCommand = Console.ReadLine()) != "Engines done")
            {
                string[] cmdArguments = secondCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int horsepOWER = int.Parse(cmdArguments[0]);
                double cubicCapacity = double.Parse(cmdArguments[1]);

                Engine engine = new Engine(horsepOWER, cubicCapacity);
                engineList.Add(engine);
            }


            List<Car> carList = new List<Car>();
            string thirdCommand;

            while ((thirdCommand = Console.ReadLine()) != "Show special")
            {
                string[] cmdArguments = thirdCommand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string make = cmdArguments[0];
                string model = cmdArguments[1];
                int year = int.Parse(cmdArguments[2]);
                double fuelQuantity = double.Parse(cmdArguments[3]);
                double fuelCompsumption = double.Parse(cmdArguments[4]);
                int engineIndex = int.Parse(cmdArguments[5]);
                int tiresIndex = int.Parse(cmdArguments[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelCompsumption, engineList[engineIndex], tireList[tiresIndex]);

                carList.Add(car);
            }

            StringBuilder sb = new StringBuilder();

            // or
            //List<Car> specialCars = cars
            //    .Where(c => c.Year >= 2017)
            //    .Where(c => c.Engine.HorsePower > 330)
            //    .Where(c => c.Tires.Sum(t => t.Pressure) >= 9 && c.Tires.Sum(t => t.Pressure) <= 10)
            //    .ToList();

            foreach (var car in carList)
            {
                int crrYear = car.Year;
                double crrEngineHorsepower = car.Engine.HorsePower;
                double crrTiresPressureSum = car.Tires.Sum(x => x.Pressure);

                if (crrYear >= 2017 && crrEngineHorsepower > 330 && crrTiresPressureSum >= 9 && crrTiresPressureSum <= 10)
                {
                    car.Drive(20);
                    sb.AppendLine($"Make: {car.Make}");
                    sb.AppendLine($"Model: {car.Model}");
                    sb.AppendLine($"Year: {car.Year}");
                    sb.AppendLine($"HorsePowers: {car.Engine.HorsePower}");
                    sb.AppendLine($"FuelQuantity: {car.FuelQuantity}");
                }                   

            }

            Console.WriteLine(sb);
            

        }
    }
}
