using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numberOfPeople = int.Parse(Console.ReadLine());
            double capacityOfElevator = int.Parse(Console.ReadLine());

            double coursesOfElevator = Math.Ceiling(numberOfPeople / capacityOfElevator);

            Console.WriteLine(coursesOfElevator);
        }
    }
}
