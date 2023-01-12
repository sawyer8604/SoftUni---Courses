using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] arguments = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = arguments[0];
                string[] clothes = arguments[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if(!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                foreach (var item in clothes)
                {
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }
                    wardrobe[color][item]++;
                }
            }

            string[] theWantedClothes = Console.ReadLine().Split(" ");
            string wantedColor = theWantedClothes[0];
            string clothing = theWantedClothes[1];

            foreach (var (crrColor, clothes) in wardrobe)
            {
                Console.WriteLine($"{crrColor} clothes:");

                foreach (var (crrClothing, count) in clothes)
                {
                    if(wantedColor == crrColor && clothing == crrClothing)
                    {
                        Console.WriteLine($"* {crrClothing} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {crrClothing} - {count}");
                    }
                }
            }
        }
    }
}
