using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> productShop = new Dictionary<string, Dictionary<string, double>>();

            string commands;

            while ((commands = Console.ReadLine()) != "Revision")
            {
                string[] cmdArguments = commands.Split(", ");

                string shop = cmdArguments[0];
                string product = cmdArguments[1];
                double price = double.Parse(cmdArguments[2]);

                if (!productShop.ContainsKey(shop))
                {
                    productShop[shop] = new Dictionary<string, double>();
                }

                if (!productShop[shop].ContainsKey(product))
                {
                    productShop[shop][product] = price;
                }
            }

            productShop = productShop.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            foreach (var shop in productShop)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var (product, price) in shop.Value)
                {
                    Console.WriteLine($"Product: {product}, Price: {price}");
                }
            }
        }
    }
}
