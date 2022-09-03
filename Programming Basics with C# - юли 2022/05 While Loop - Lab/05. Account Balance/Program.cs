using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "NoMoreMoney")
            {
                double currentMoney = double.Parse(input);

                if (currentMoney < 0)
                {

                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += currentMoney;

                Console.WriteLine($"Increase: {currentMoney:f2}");

                input = Console.ReadLine();

            }

            Console.WriteLine($"Total: {sum:f2}");
        }

    }
}
