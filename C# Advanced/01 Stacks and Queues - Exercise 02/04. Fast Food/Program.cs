using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();           

            Queue<int> queue = new Queue<int>(orders);

            int biggestOrder = queue.Max();

            while (quantityOfFood > 0 && queue.Any())
            {
                if(quantityOfFood - queue.Peek() >= 0)
                {
                    int crrOrder = queue.Dequeue();

                    quantityOfFood -= crrOrder;
                }
                else
                {
                    break;
                }

                
            }

            if(queue.Any())
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
            else
            {
                Console.WriteLine(biggestOrder);
                Console.WriteLine("Orders complete");
            }
        }
    }
}
