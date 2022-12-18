using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] counts = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int numberOfLinesFirstSet = counts[0];
            int secondSetLines = counts[1];

            HashSet<int> firstNumbers = new HashSet<int>();

            HashSet<int> secondNumbers  = new HashSet<int>();

            for (int i = 0; i < numberOfLinesFirstSet; i++)
            {
                int numberToAdd = int.Parse(Console.ReadLine());
                firstNumbers.Add(numberToAdd);

            }

            for (int i = 0; i < secondSetLines; i++)
            {
                int numberToAdd = int.Parse(Console.ReadLine());
                secondNumbers.Add(numberToAdd);

            }

            firstNumbers.IntersectWith(secondNumbers);

            Console.WriteLine(string.Join(" ", firstNumbers));
        }
    }
}
