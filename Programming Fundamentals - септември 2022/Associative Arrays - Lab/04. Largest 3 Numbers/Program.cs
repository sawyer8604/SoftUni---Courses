using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int [] firstThreeLargestNum = numbers.OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(String.Join(" ", firstThreeLargestNum));
        }
    }
}
