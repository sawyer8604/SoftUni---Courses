using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int kNumbers = numbers.Count / 4;
            int skipKNumbers = numbers.Count - kNumbers * 2;

            List<int> firstNumbers = numbers.Take(kNumbers).Reverse().ToList();

            numbers.Reverse();

            List<int> secondNumbers = numbers.Take(kNumbers).ToList();

            numbers.Reverse();

            List<int> concatNumber = firstNumbers.Concat(secondNumbers).ToList();

            List<int> skipNumbers = numbers.Skip(kNumbers).Take(skipKNumbers).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < concatNumber.Count; i++)
            {
                result.Add(concatNumber[i] + skipNumbers[i]);
            }

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
