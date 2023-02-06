using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle car = new Car(10, 100);
            car.Drive(10);
            Console.WriteLine(car.Fuel);

            Vehicle sc = new SportCar(200, 200);
            sc.Drive(10);
            Console.WriteLine(sc.Fuel);
        }
    }
}
