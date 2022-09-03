using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int countOfSudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double numberOfLightsabe = Math.Ceiling(countOfSudents * 1.10);
            double numberOfBelts = countOfSudents - countOfSudents / 6;

            double allPrice = countOfSudents * robesPrice + numberOfLightsabe * lightsabersPrice + numberOfBelts * beltsPrice;

            

            if (budget >= allPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {allPrice:f2}lv.");
            }
            else
            {
                double difference = Math.Abs(allPrice - budget);

                Console.WriteLine($"John will need {difference:f2}lv more.");
            }
        }
    }
}
