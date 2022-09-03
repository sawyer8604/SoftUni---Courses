using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var startNumber = int.Parse(Console.ReadLine());
            var endNumber = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int value = startNumber; value <= endNumber; value++)
            {
                Console.Write($"{value} ");
                sum += value;

            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
