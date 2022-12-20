using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Func<int, bool> filter = n => n % 2 == 0;

            numbers = numbers.Where(filter).OrderBy(x => x).ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
