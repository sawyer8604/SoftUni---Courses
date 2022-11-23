using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @">>(?<product>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>[0-9]+)";

            string input;
            Regex regex = new Regex(patern);

            List<string> products = new List<string>();

            double totalMoney = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(input);

                if(match.Success)
                {
                    string product = match.Groups["product"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    int quantity = int.Parse(match.Groups["quantity"].Value);

                    totalMoney += price * quantity;

                    products.Add(product);
                }
            }
            Console.WriteLine("Bought furniture:");

            foreach (string product in products)
            {
                Console.WriteLine(product);
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
