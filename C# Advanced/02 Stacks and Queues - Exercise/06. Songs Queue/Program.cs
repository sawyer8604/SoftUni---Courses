using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);
                        

            while (queue.Any())
            {
                string[] command = Console.ReadLine().Split();

                string cmdArgument = command[0];

                switch (cmdArgument)
                {
                    case "Play":

                        if(queue.Any())
                        { 
                            queue.Dequeue();
                        }

                        break;

                    case "Add":
                        string song = string.Join(" ", command.Skip(1));

                        if(!queue.Contains(song))
                        {
                            queue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }

                        break;

                    case "Show":

                        Console.WriteLine(string.Join(", ", queue));
                        break;
                }
                
            }

            Console.WriteLine("No more songs!");
        }
       
    }
}
