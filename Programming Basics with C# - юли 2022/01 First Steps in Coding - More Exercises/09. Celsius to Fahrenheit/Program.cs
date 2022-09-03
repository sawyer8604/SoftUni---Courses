using System;

namespace Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double farenhaid = celsius * 1.8 + 32;
            Console.WriteLine(Math.Round(farenhaid, 2));
        }
    }
}
