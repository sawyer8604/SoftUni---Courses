using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nuberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();

            for (int i = 0; i < nuberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = input[0];
                int rarity = int.Parse(input[1]);


                if (!plants.ContainsKey(plant))
                {
                    plants[plant] = new List<double>() { 0, 0, 0};

                }

                plants[plant][0] = rarity;


            }

            string commands;
            char[] chars = { ':', ' ', '-' };

            
            while ((commands = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArguments = commands.Split(chars, StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];


                if (firstCommand == "Rate")
                {
                    string plant = cmdArguments[1];
                    double rating = double.Parse(cmdArguments[2]);
                   

                    if(plants.ContainsKey(plant))
                    {
                        plants[plant][1] += rating;
                        plants[plant][2]++;

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if(firstCommand == "Update")
                {
                    string plant = cmdArguments[1];
                    double newRarity = double.Parse(cmdArguments[2]);

                    if(plants.ContainsKey(plant))
                    {
                        plants[plant][0] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                }
                else if (firstCommand == "Reset")
                {
                    string plant = cmdArguments[1];

                    if(plants.ContainsKey(plant))
                    {
                        plants[plant][1] = 0;
                        plants[plant][2] = 0.00;

                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }

            }


            Console.WriteLine("Plants for the exhibition:");

            foreach (var (plant, rarity) in plants)
            {
                double avarage = 0;
                
                if(rarity[1] == 0)
                {
                    avarage = 0;
                }
                else
                {
                    avarage = rarity[1] / rarity[2];
                }
                                    

                Console.WriteLine($"- {plant}; Rarity: {rarity[0]}; Rating: {avarage:f2}");
            }
        

        }

    }
}
