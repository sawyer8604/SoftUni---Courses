using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] countOfNumber = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> first = new HashSet<int>();
            HashSet<int> second = new HashSet<int>();

            int numberOfFirstLines = countOfNumber[0];
            int numberOfSecondLines = countOfNumber[1];

            for (int i = 0; i < numberOfFirstLines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                first.Add(number);

            }

            for (int i = 0; i < numberOfSecondLines; i++)
            {
                int number = int.Parse(Console.ReadLine());
                second.Add(number);
            }

            List<int> numbers = first.Intersect(second).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        } 
    }
}
