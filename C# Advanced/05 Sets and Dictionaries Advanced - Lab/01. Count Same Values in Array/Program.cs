using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double crrNumer = numbers[i];

                if(!dict.ContainsKey(crrNumer))
                {
                    dict[crrNumer] = 0;

                    // or 
                    //dict.Add(crrNumer, 0);
                }

                dict[crrNumer]++;

            }

            foreach (var number in dict)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
