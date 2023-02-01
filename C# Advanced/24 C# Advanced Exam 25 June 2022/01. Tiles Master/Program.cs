using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> kitchen = new Dictionary<string, int>();

            kitchen.Add("Sink", 40);
            kitchen.Add("Oven", 50);
            kitchen.Add("Countertop", 60);
            kitchen.Add("Americano", 150);
            kitchen.Add("Wall", 70);


            int[] whiteTiles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> whiteStack = new Stack<int>(whiteTiles);

            int[] greyTiles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> grayQueue= new Queue<int>(greyTiles);

            Dictionary<string, int> newTile = new Dictionary<string, int>();
            string Floor = "Floor";

            while (whiteStack.Any() && grayQueue.Any())
            {                
                int crrWhite = whiteStack.Peek();
                int crrGrey = grayQueue.Peek();
                int sum = crrWhite + crrGrey;

                bool isEqual = false;

                if(crrWhite == crrGrey)
                {
                    foreach (var (name, area) in kitchen)
                    {
                        if(sum == area)
                        {
                            isEqual = true;

                            if(!newTile.ContainsKey(name))
                            {
                                newTile[name] = 1;
                            }
                            else
                            {
                                newTile[name]++;
                            }

                            whiteStack.Pop();
                            grayQueue.Dequeue();

                            break;
                           
                        }
                    }

                    if(isEqual == false)
                    {
                        if (!newTile.ContainsKey(Floor))
                        {
                            newTile[Floor] = 0;
                        }
                        newTile[Floor]++;
                        whiteStack.Pop();
                        grayQueue.Dequeue();

                    }

                }
                else
                {
                    int crrWhiteTile = whiteStack.Pop();
                    crrWhiteTile /= 2;
                    whiteStack.Push(crrWhiteTile);

                    int crrGrayTile = grayQueue.Dequeue();
                    grayQueue.Enqueue(crrGrayTile);
                }

            }

            if(!whiteStack.Any())
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteStack)}");
            }

            if (!grayQueue.Any())
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", grayQueue)}");
            }


            foreach (var (name, count) in newTile.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{name}: {count}");
            }
        }
    }
}
