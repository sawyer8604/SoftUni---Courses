using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Audi";

            car.Model = "A5";

            car.Year = 2011;

            Console.WriteLine($"Make: {car.Make}");

            Console.WriteLine($"Model: {car.Model}");

            Console.WriteLine($"Year: {car.Year}");
        }
    }
}
