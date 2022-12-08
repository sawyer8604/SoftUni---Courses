using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split(" ");

            int numberOfToss = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(kids);

            int counter = 1;

            while (queue.Count > 1)
            {                          

                if(counter == numberOfToss)
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                    counter = 1;
                    continue;
                }

                string crrKid = queue.Dequeue();
                queue.Enqueue(crrKid);

                counter++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }
    }
}
