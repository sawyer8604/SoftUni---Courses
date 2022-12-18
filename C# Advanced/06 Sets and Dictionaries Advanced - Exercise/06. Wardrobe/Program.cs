using System;
using System.Collections.Generic;
using System.Drawing;

namespace _06._Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string[] delimiters = { " -> ", "," };

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] clothes = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                string colour = clothes[0];

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                }

                for (int j = 1; j < clothes.Length; j++)
                {
                    string crrClothes = clothes[j];

                    if (!wardrobe[colour].ContainsKey(crrClothes))
                    {
                        wardrobe[colour][crrClothes] = 0;
                    }
                    wardrobe[colour][crrClothes]++;
                }
            }


            string[] check = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string colourToCheck = check[0];
            string clothesToCheck = check[1];

            foreach (var (crrColour, crrClothes) in wardrobe)
            {
                Console.WriteLine($"{crrColour} clothes:");

                foreach (var (cloths, count) in crrClothes)
                {
                    if (crrColour == colourToCheck && cloths == clothesToCheck)
                    {
                        Console.WriteLine($"* {cloths} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloths} - {count}");
                    }
                }
            }



        }
    }
}
