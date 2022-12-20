using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> parser = n => double.Parse(n);

            double[] numbers = Console.ReadLine().Split(", ").Select(parser).ToArray();

            Func<double, double> vatAdder = n => n * 1.2;

            numbers = numbers.Select(vatAdder).ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }

    }
}
