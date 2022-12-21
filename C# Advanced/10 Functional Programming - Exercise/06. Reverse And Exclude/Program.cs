using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, List<int>> revers = number =>
            {
                List<int> reversedNumber = new List<int>();


                for (int i = number.Count - 1; i >= 0; i--)
                {
                    reversedNumber.Add(number[i]);
                }

                return reversedNumber;
            };

            Func<List<int>, Predicate<int>, List<int>> exclude = (number, match) =>
            {
                

                for (int i = 0; i < number.Count; i++)
                {
                    if (match(number[i]))
                    {
                        number.Remove(number[i]);
                        i--;
                    }
                }

                return number;
            };

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int numberForDivision = int.Parse(Console.ReadLine());

            numbers = exclude(numbers, number => number % numberForDivision == 0);
            numbers = revers(numbers);

            Console.WriteLine(string.Join(" ", numbers));

        }

    }
}
