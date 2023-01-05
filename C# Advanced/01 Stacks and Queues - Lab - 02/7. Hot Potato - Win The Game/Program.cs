using System;
using System.Collections.Generic;

namespace _7._Hot_Potato___Win_The_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] children = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(children);

            int numberForRemove = int.Parse(Console.ReadLine());

            Console.WriteLine($"You have to be in this position to win the game: {children.Length % numberForRemove -1}");

            while (queue.Count > 1)
            {

                for (int i = 1; i < numberForRemove; i++)
                {
                    string name = queue.Dequeue();
                    queue.Enqueue(name);
                }
                string childToRemove = queue.Dequeue();

                Console.WriteLine($"Removed {childToRemove}");
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
