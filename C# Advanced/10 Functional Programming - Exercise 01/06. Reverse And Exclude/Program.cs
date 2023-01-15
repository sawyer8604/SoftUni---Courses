using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Reverse()
                .Select(int.Parse)
                .ToArray();

            int divisionNum = int.Parse(Console.ReadLine());

            int[] result = numbers.Where(x => x % divisionNum != 0).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
