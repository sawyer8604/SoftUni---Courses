using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPassedCars = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            string input;

            int passedCount = 0;

            while ((input = Console.ReadLine()) != "end")
            {
                if(input == "green")
                {
                    if(numberOfPassedCars > queue.Count)
                    {
                        numberOfPassedCars = queue.Count;
                    }

                    for (int i = 0; i < numberOfPassedCars; i++)
                    {

                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        passedCount++;
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                
            }

            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
    }
}
