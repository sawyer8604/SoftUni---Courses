using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputHouses = Console.ReadLine();
            
            int[] houses = inputHouses.Split("@").Select(int.Parse).ToArray();

            string commands;

            int startIndex = 0;           

            while ((commands = Console.ReadLine()) != "Love!")
            {
                string[] cmdArguments = commands.Split();

                string jump = cmdArguments[0];

                int jumLength = int.Parse(cmdArguments[1]);                          

                if (startIndex + jumLength >= houses.Length)
                {
                    startIndex = 0;

                    if (houses[startIndex] == 0)
                    {
                        Console.WriteLine($"Place {startIndex} already had Valentine's day.");
                    }
                    else
                    {
                        houses[startIndex] -= 2;

                        if (houses[startIndex] == 0)
                        {
                            Console.WriteLine($"Place {startIndex} has Valentine's day.");
                        }
                    }

                }
                else
                {
                    startIndex += jumLength;

                    if (houses[startIndex] == 0)
                    {
                        Console.WriteLine($"Place {startIndex} already had Valentine's day.");
                    }
                    else
                    {
                        houses[startIndex] -= 2;
                        if (houses[startIndex] == 0)
                        {
                            Console.WriteLine($"Place {startIndex} has Valentine's day.");
                        }
                    }
                }
                

            }
            int counter = 0;
            for (int i = 0; i < houses.Length; i++)
            {
                if(houses[i] != 0)
                {
                    counter++;
                }
            }

            Console.WriteLine($"Cupid's last position was {startIndex}.");

            if(counter != 0)
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
