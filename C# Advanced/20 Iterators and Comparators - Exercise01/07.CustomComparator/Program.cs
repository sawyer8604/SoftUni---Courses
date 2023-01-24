using System;
using System.Linq;

namespace _07.CustomComparator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();           

            Func<int, int, int> CustomComparator = (x, y) =>
            {
                if(x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }

                if(x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }

                if(x > y)
                {
                    return 1;
                }

                if(x < y)
                {
                    return -1;
                }

                return 0;
            };

            Array.Sort(numbers, (x, y) => CustomComparator(x, y));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
