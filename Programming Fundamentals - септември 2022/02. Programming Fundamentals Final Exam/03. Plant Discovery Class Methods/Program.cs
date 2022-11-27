using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace _03._Plant_Discovery_With_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nuberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, Raritys> plants = new Dictionary<string, Raritys>();

            for (int i = 0; i < nuberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = input[0];
                double rarity = int.Parse(input[1]);
                double raiting = 0;
                int counter = 0;


                if (!plants.ContainsKey(plant))
                {
                    plants[plant] = new Raritys(rarity, raiting, counter);

                }

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

                    GetRate(plants, plant, rating);

                }
                else if (firstCommand == "Update")
                {
                    string plant = cmdArguments[1];
                    double newRarity = double.Parse(cmdArguments[2]);

                    UpdatePlants(plants, plant, newRarity);

                }
                else if (firstCommand == "Reset")
                {
                    string plant = cmdArguments[1];

                    ResetRaiting(plants, plant);
                }

            }
            double avarage = 0;

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants)
            {
                if (plant.Value.Raiting == 0)
                {
                    avarage = 0;
                }
                else
                {
                    avarage = plant.Value.Raiting / plant.Value.Counter;
                }


                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {avarage:f2}");
            }
        }

        static void GetRate(Dictionary<string, Raritys> plants, string plant, double rating)
        {
            if (plants.ContainsKey(plant))
            {
                plants[plant].Raiting += rating;
                plants[plant].Counter++;

            }
            else
            {
                Console.WriteLine("error");
            }
        }

        static void UpdatePlants(Dictionary<string, Raritys> plants, string plant, double newRarity)
        {
            if (plants.ContainsKey(plant))
            {
                plants[plant].Rarity = newRarity;
            }
            else
            {
                Console.WriteLine("error");
            }
        }
        static void ResetRaiting(Dictionary<string, Raritys> plants, string plant)
        {
            if (plants.ContainsKey(plant))
            {
                plants[plant].Raiting = 0;
                plants[plant].Counter = 0;

            }
            else
            {
                Console.WriteLine("error");
            }
        }

        public class Raritys
        {
            public Raritys(double rarity, double raiting, int counter)
            {
                Rarity = rarity;
                Raiting = raiting;
                Counter = counter;
            }

            public double Rarity { get; set; }
            public double Raiting { get; set; }
            public int Counter { get; set; }
        }
    }
}
