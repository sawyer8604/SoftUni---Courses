using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int startNun = numbers[0];
            int count = numbers[1] - startNun;

            List<int> allNums = Enumerable.Range(startNun, count + 1).ToList();

            string command = Console.ReadLine();

            Predicate<int> IsEven = x => x % 2 == 0;
            Predicate<int> IsOdd = x => x % 2 != 0;

            if (command == "even")
            {

                Console.WriteLine(string.Join(" ", allNums.Where(x => IsEven(x))));
            }
            else
            {
                Console.WriteLine(string.Join(" ", allNums.Where(x => IsOdd(x))));
            }


        }

    }
}
