using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullets = int.Parse(Console.ReadLine());

            int gunBarel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] locks = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int intelligence = int.Parse(Console.ReadLine());


            Stack<int> stackBullets = new Stack<int>(bullets);

            Queue<int> queueLocks = new Queue<int>(locks);

            int usedBullets = 0;

            while (queueLocks.Any() && stackBullets.Any())
            {

                usedBullets ++;

                int crrLock = queueLocks.Peek();

                int crrBulet = stackBullets.Pop();

                if (crrBulet <= crrLock)
                {
                    queueLocks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                }


                if (usedBullets % gunBarel == 0 && stackBullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }


            }


            if (queueLocks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
            }
            else
            {
                Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${intelligence - usedBullets * priceOfBullets}");

            }


        }
    }
}
