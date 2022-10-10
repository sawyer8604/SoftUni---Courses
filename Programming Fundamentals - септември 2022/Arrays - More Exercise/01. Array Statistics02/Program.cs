using System;
using System.Linq;

namespace _01._Array_Statistics02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }

            }
            Console.WriteLine($"Min = {minValue}");

            int maxValue = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }

            }            
            Console.WriteLine($"Max = {maxValue}");

            int sum = numbers.Sum();
            Console.WriteLine($"Sum = {sum}");

            double avarage = (double)numbers.Sum() / numbers.Length;
            Console.WriteLine($"Average = {avarage}");
        }

    }
}
