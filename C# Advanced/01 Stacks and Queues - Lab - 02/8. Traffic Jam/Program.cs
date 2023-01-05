using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCarsThatCanPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int passedCarCount = 0;

            string command;

            while ((command = Console.ReadLine()) != "end")
            {                

                if(command == "green")
                {
                    for (int i = 0; i < numberOfCarsThatCanPass; i++)
                    {
                        if(cars.Count == 0)
                        {
                            break;
                        }

                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCarCount++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }

            Console.WriteLine($"{passedCarCount} cars passed the crossroads.");
        }
    }
}
