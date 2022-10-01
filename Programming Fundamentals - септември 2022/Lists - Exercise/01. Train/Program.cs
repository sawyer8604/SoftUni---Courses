using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string commands = Console.ReadLine();

            while (commands != "end")
            {
                string[] tokens = commands.Split();
                
                if(tokens.Length == 2)
                {
                    int wagon = int.Parse(tokens[1]);
                    wagons.Add(wagon);

                }
                else
                {
                    int passangers = int.Parse(tokens[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        

                        if (passangers + wagons[i] <= maxCapacity)
                        {
                            int currentPasengers = wagons[i] + passangers;
                            wagons[i] = currentPasengers;
                            break;
                        }
                    }
                    
                }
                commands = Console.ReadLine();

            }
            Console.WriteLine(String.Join(" ", wagons));

        }

    }
}
