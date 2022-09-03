using System;

namespace _01._Numbers_from_1_to_100
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number = 0;

            while (number < 100)
            {
                number++;
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
