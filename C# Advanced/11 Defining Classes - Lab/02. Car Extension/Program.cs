using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";

            car.Model = "Polo";

            car.Year = 2004;

            car.FuelQuantity = 200;

            car.FuelConsumption = 200;

            car.Drive(20);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
