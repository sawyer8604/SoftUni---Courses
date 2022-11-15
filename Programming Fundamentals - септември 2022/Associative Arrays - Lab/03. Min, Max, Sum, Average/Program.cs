using System;
using System.Linq;

namespace _03._Min__Max__Sum__Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            int sum = numbers.Sum();
            double avarage = numbers.Average();
            int min = numbers.Min();
            int max = numbers.Max();
            int first = numbers.First();
            int las = numbers.Last();

            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {avarage}");
        }
    }
}
