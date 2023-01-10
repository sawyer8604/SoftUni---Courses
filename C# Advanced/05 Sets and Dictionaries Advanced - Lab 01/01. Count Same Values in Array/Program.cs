using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split(" ")
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> numbers = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double crrNumebr = input[i];

                if(!numbers.ContainsKey(crrNumebr))
                {
                    numbers[crrNumebr] = 0;
                }

                numbers[crrNumebr]++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
