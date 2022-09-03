using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var divisible = 0;

            if (number % 10 == 0)
            {
                divisible = 10;
            }
            else if (number % 7 == 0)
            {
                divisible = 7;
            }
            else if (number % 6 == 0)
            {
                divisible = 6;
            }
            else if (number % 3 == 0)
            {
                divisible = 3;
            }
            else if (number % 2 == 0)
            {
                divisible = 2;
            }
            else
            {
                Console.WriteLine("Not divisible");
                return;
            }
            Console.WriteLine($"The number is divisible by {divisible}");
        }
    }
}
