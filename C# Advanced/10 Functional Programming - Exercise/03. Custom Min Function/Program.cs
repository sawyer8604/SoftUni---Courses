using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> getMinNumber = numbers =>
            {
                int minNumber = int.MaxValue;

                foreach (var number in numbers)
                {
                    if(number < minNumber)
                    {
                        minNumber = number;
                    }
                }

                return minNumber;
            };

            int[]  numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(getMinNumber(numbers));
        }
    }
}
