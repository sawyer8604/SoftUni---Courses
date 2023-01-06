using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> queue = new Queue<string>(songs);

            while (queue.Any())
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = command[0];

                switch (firstCommand)
                {
                    case "Play":

                        queue.Dequeue();

                        break;

                    case "Add":

                        string[] song = command.Skip(1).ToArray();

                        string songName = string.Join(" ", song);
                        if(queue.Contains(songName))
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        else
                        {
                            queue.Enqueue(songName);
                        }
                        
                        break;

                    case "Show":

                        if(queue.Any())
                        {
                            Console.WriteLine(string.Join(", ", queue));
                        }

                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
