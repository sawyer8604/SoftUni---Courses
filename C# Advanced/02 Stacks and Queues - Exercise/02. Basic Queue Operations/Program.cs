using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int numberToEnqueue = numbers[0];
            int numberToDequeue = numbers[1];
            int numberToCheck = numbers[2];

            int[] collection = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue= new Queue<int>();

            for (int i = 0; i < numberToEnqueue; i++)
            {
                queue.Enqueue(collection[i]);
            }

            if(numberToDequeue > queue.Count)
            {
                numberToDequeue = queue.Count;
            }

            for (int i = 0; i < numberToDequeue; i++)
            {
                queue.Dequeue();    
            }
                
            if(!queue.Any())
            {
                Console.WriteLine(0);
            }
            else if (queue.Contains(numberToCheck))
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
