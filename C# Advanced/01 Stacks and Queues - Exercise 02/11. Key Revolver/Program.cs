using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());

            int sizeOfGunBarel = int.Parse(Console.ReadLine());

            int[] bullets = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] locks = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int valueOfTheIntelligence = int.Parse(Console.ReadLine());

            Stack<int> stackBullets = new Stack<int> (bullets);

            Queue<int> queueLocks = new Queue<int>(locks);

            int crrGunBarel = sizeOfGunBarel;          

            while (stackBullets.Any() && queueLocks.Any() && valueOfTheIntelligence > 0)
            {
                crrGunBarel--;                

                int crrBullet = stackBullets.Pop();

                valueOfTheIntelligence -= priceOfBullet;

                int crrLock = queueLocks.Peek();

                if(crrBullet <= crrLock)
                {
                    Console.WriteLine("Bang!");

                    queueLocks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (crrGunBarel == 0 && stackBullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    crrGunBarel = sizeOfGunBarel;
                }

            }

            if(queueLocks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
            }
            else
            {
                Console.WriteLine($"{stackBullets.Count} bullets left. Earned ${valueOfTheIntelligence}");
            }


        }
    }
}
