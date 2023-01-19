using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();   

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                
                string model = carInformation[0];
                int engineSpeed = int.Parse(carInformation[1]);
                int enginePower = int.Parse(carInformation[2]);
                int cargoWeight = int.Parse(carInformation[3]);
                string cargoType = carInformation[4];
                double tire1PressureOne = double.Parse(carInformation[5]);
                int tireAgeOne = int.Parse(carInformation[6]);
                double tire1PressureTwo = double.Parse(carInformation[7]);
                int tireAgeTwo = int.Parse(carInformation[8]);
                double tire1PressureThree = double.Parse(carInformation[9]);
                int tireAgeThree = int.Parse(carInformation[10]);
                double tire1PressureFour = double.Parse(carInformation[11]);
                int tireAgeFour = int.Parse(carInformation[12]);

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tires[] tires = new Tires[4];
                tires[0] = new Tires(tireAgeOne, tire1PressureOne);
                tires[1] = new Tires(tireAgeTwo, tire1PressureTwo);
                tires[2] = new Tires(tireAgeThree, tire1PressureThree);
                tires[3] = new Tires(tireAgeFour, tire1PressureFour);

                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);

            }

            string typeOfCargo = Console.ReadLine();

            List<Car> resultCars = new List<Car>();

            if (typeOfCargo == "fragile")
            {
                resultCars = cars.Where(x => x.Cargo.Type == "fragile")
                                 .Where(x => x.Tires.Any(x => x.Pressure < 1)).ToList();                    
            }
            else
            {
                resultCars = cars.Where(x => x.Cargo.Type == "flammable")
                                 .Where(x => x.Engine.Power > 250).ToList();
            }

            resultCars.ForEach(x => Console.WriteLine(x.Model));
           
        }
    }
}
