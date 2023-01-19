using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _08.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engineList = new List<Engine>();

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInformations = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //"{model} {power} {displacement} {efficiency}                

                string model = engineInformations[0];
                int power = int.Parse(engineInformations[1]);

                if (engineInformations.Length == 4)
                {
                    int displacement = int.Parse(engineInformations[2]);
                    string efficiency = engineInformations[3];

                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engineList.Add(engine);
                }
                else if(engineInformations.Length == 3)
                {
                    bool isDisplacement = int.TryParse(engineInformations[2], out int result);

                    if(isDisplacement)
                    {

                        Engine engine = new Engine(model, power, result);
                        engineList.Add(engine);
                    }
                    else
                    {
                        string efficiency = engineInformations[2];
                        Engine engine = new Engine(model, power, efficiency);
                        engineList.Add(engine);
                    }
                }
                else
                {
                    Engine engine = new Engine(model, power);
                    engineList.Add(engine);
                }                
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {

                string[] carInformation = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                //"{model} {engine} {weight} {color}".                

                string model = carInformation[0];
                string crrEngine = carInformation[1];

                Engine engineFind = engineList.Where(x => x.Model == crrEngine).FirstOrDefault();

                if (carInformation.Length == 4)
                {
                    int weight = int.Parse(carInformation[2]);
                    string color = carInformation[3];

                    Car car = new Car (model, engineFind, weight, color);
                    cars.Add(car);
                }
                else if (carInformation.Length == 3)
                {
                    bool isDisplacement = int.TryParse(carInformation[2], out int result);

                    if (isDisplacement)
                    {
                        Car car = new Car(model, engineFind, result);
                        cars.Add(car);
                    }
                    else
                    {
                        string color = carInformation[2];
                        Car car = new Car(model, engineFind, color);
                        cars.Add(car);
                    }
                }
                else
                {
                    Car car = new Car(model, engineFind);
                    cars.Add(car);
                }
               
            }
            StringBuilder sb = new StringBuilder();

            foreach (var car in cars)
            { 
                sb.AppendLine($"{car.Model}:");
                sb.AppendLine($"  {car.Engine.Model}:");
                sb.AppendLine($"    Power: {car.Engine.Power}");

                if (car.Engine.Displacement == null)
                {
                    sb.AppendLine($"    Displacement: n/a");
                }
                else
                {
                    sb.AppendLine($"    Displacement: {car.Engine.Displacement}");
                }

                if (car.Engine.Efficiency == null)
                {
                    sb.AppendLine($"    Efficiency: n/a");
                }
                else
                {
                    sb.AppendLine($"    Efficiency: {car.Engine.Efficiency}");
                }
                

                if(car.Weight == null)
                {
                    sb.AppendLine($"  Weight: n/a");
                }
                else
                {
                    sb.AppendLine($"  Weight: {car.Weight}");
                }

                if (car.Color == null)
                {
                    sb.AppendLine($"  Color: n/a");
                }
                else
                {
                    sb.AppendLine($"  Color: {car.Color}");
                }
                
            }
            Console.WriteLine(sb);


        }
    }
}
