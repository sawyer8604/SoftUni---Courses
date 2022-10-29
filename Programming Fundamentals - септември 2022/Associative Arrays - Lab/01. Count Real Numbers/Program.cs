using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> countByNumber = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {

                if(countByNumber.ContainsKey(number))
                {
                    countByNumber[number]++;
                }
                else
                {
                    countByNumber.Add(number, 1);
                }
            }

            foreach (var number in countByNumber)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }


        }
    }
}
