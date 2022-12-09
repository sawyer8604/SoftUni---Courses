using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] orders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(orders);

            int maxOrder = queue.Max();

            while (quantity > 0)
            {

                int crrOrder = queue.Peek();
                if (quantity >= crrOrder)
                {
                    quantity -= crrOrder;
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine(maxOrder);
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    return;
                }

                if(!queue.Any())
                {
                    break;
                }
                
            }

            Console.WriteLine(maxOrder);
            Console.WriteLine("Orders complete");

        }
    }
}
