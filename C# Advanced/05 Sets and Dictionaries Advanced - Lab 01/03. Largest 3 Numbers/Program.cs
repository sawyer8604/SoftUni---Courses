using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
                                   
                int[] result = input.OrderByDescending(x => x).Take(3).ToArray();
                Console.WriteLine(string.Join(" ", result));            
            
        }
    }
}
