namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new SportCar(215, 110);
            vehicle.Drive(10);

            System.Console.WriteLine(vehicle.Fuel);

            Vehicle vehicle1 = new RaceMotorcycle(215, 110);
            vehicle1.Drive(10);

            System.Console.WriteLine(vehicle1.Fuel);

        }
    }
}
