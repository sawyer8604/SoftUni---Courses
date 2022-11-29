using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while ((input = Console.ReadLine()) != "Sail")
            {
                string[] arguments = input.Split("||", StringSplitOptions.RemoveEmptyEntries);

                string city = arguments[0];

                int population = int.Parse(arguments[1]);
                int gold = int.Parse(arguments[2]);

                if(!cities.ContainsKey(city))
                {
                    cities[city] = new List<int>() { population, gold };
                }
                else
                {
                    cities[city][0] += population;
                    cities[city][1] += gold;
                }

            }

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] cmdArguments = commands.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                if(firstCommand == "Plunder")
                {
                    string town = cmdArguments[1];
                    int people = int.Parse(cmdArguments[2]);
                    int gold = int.Parse(cmdArguments[3]);

                    if(cities.ContainsKey(town))
                    {
                        cities[town][0] -= people;
                        cities[town][1] -= gold;

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                        if(cities[town][0] <= 0 || cities[town][1] <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            cities.Remove(town);
                        }

                    }


                }
                else if(firstCommand == "Prosper")
                {
                    string town = cmdArguments[1];
                    int gold = int.Parse(cmdArguments[2]);

                    if(cities.ContainsKey(town))
                    {
                        if (gold < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            continue;
                        }

                        cities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");

                    }
                   


                }

            }

            if(cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }

            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
