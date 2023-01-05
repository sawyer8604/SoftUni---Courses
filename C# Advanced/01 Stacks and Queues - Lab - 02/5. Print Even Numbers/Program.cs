using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> evenQueue= new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenQueue.Enqueue(numbers[i]);
                }
            }

            // or  Queue<int> queue = new Queue<int>(numbers.Where(x => x % 2 == 0));

            Console.WriteLine(string.Join(", ", evenQueue));
        }
    }
}
