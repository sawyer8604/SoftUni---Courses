using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string commands;
            int lenght = 0;

            while ((commands = Console.ReadLine()) != "Love!")
            {
                string[] cmdArguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                int jumpIndex = int.Parse(cmdArguments[1]);

                lenght += jumpIndex;

                if (lenght >= houses.Length)
                {
                    lenght = 0;

                }

                if (houses[lenght] == 0)
                {
                    Console.WriteLine($"Place {lenght} already had Valentine's day.");
                }
                else
                {

                    houses[lenght] -= 2;

                    if (houses[lenght] == 0)
                    {
                        Console.WriteLine($"Place {lenght} has Valentine's day.");
                    }

                }

            }
            int counter = 0;

            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i] != 0)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Cupid's last position was {lenght}.");

            if (counter != 0)
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");

            }
        }
    }
}
