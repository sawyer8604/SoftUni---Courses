using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numberToEnqueue = commands[0];
            int numberToDequeue = commands[1];
            int numberToCheck = commands[2];



            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (numberToEnqueue <= numberToDequeue)
            {
                Console.WriteLine(0);
                return;
            }

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numberToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < numberToDequeue; i++)
            {
                queue.Dequeue();
            }


            if (queue.Contains(numberToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
