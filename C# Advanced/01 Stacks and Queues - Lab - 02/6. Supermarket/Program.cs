using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;

            Queue<string> queue = new Queue<string>();

            while ((command = Console.ReadLine()) != "End")
            {
                if (command == "Paid")
                {
                    while (queue.Any())
                    {
                        Console.WriteLine(queue.Dequeue());
                    }

                }
                else
                {
                    queue.Enqueue(command);
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
