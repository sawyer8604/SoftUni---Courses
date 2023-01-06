using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] bottles = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int wastedWater = 0;

            Stack<int> bottleStack = new Stack<int>(bottles);

            Queue<int> cupQueue = new Queue<int>(cups);

            while (bottleStack.Any() && cupQueue.Any())
            {
                int crrBottle = bottleStack.Pop();

                int crrCup = cupQueue.Peek();

                if(crrBottle - crrCup >= 0)
                {
                    cupQueue.Dequeue();

                    wastedWater += crrBottle - crrCup;

                    continue;
                }

                if(crrCup - crrBottle > 0)
                {
                    crrCup -= crrBottle;

                    while (crrCup > 0 && bottleStack.Any())
                    {
                        crrBottle = bottleStack.Pop();
                        crrCup -= crrBottle;
                    }

                    wastedWater += Math.Abs(crrCup);
                    cupQueue.Dequeue();
                }

            }

            if(bottleStack.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottleStack)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupQueue)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
