using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] cupCapacity = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] bottle = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> bottleStack = new Stack<int>(bottle);

            Queue<int> cupQueue = new Queue<int>(cupCapacity);

            int wastedWater = 0;
            int needetWater = 0;

            while (bottleStack.Any() && cupQueue.Any())
            {
                int crrBottle = bottleStack.Pop();

                int crrCup = cupQueue.Peek();

                needetWater = 0;

                if (crrCup <= crrBottle)
                {
                    cupQueue.Dequeue();

                    wastedWater += crrBottle - crrCup;

                    continue;
                }

                if (crrCup > crrBottle)
                {
                    needetWater = crrCup - crrBottle;

                    while (needetWater > 0)
                    {
                        needetWater -= crrBottle = bottleStack.Pop();

                    }
                    cupQueue.Dequeue();
                    wastedWater += Math.Abs(needetWater);

                }


            }

            if (bottleStack.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottleStack)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");

            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupQueue)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
