using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>[\d].*[\d])\!(?<quantity>[0-9]+)";

            string input;

            double totalMoney = 0;

            List<string> furnitures = new List<string>();   

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if(match.Success)
                {
                    string name = match.Groups["name"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);


                    furnitures.Add(name);

                    totalMoney += price * quantity;

                }

            }

            Console.WriteLine("Bought furniture:");

            foreach (string furniture in furnitures)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
