using System;
using System.Linq;

namespace _02._Sum_Numbers_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);

            int[] numbers = Console.ReadLine().Split(", ").Select(parser).ToArray();

            int count = numbers.Length;

            int sum = numbers.Sum();

            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
