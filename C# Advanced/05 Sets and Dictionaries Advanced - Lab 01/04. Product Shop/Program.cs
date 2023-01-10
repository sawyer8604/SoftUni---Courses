using System;
using System.Collections.Generic;

namespace _04._Product_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<string, Dictionary<string, double>> products = new SortedDictionary<string, Dictionary<string, double>>();

            string input;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] inputArguments = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = inputArguments[0];
                string product = inputArguments[1];
                double price = double.Parse(inputArguments[2]);

                if(!products.ContainsKey(shop))
                {
                    products[shop] = new Dictionary<string, double>();
                }
                if (!products[shop].ContainsKey(product))
                {
                    products[shop][product] = 0;
                }

                products[shop][product] = price;
            }

            foreach (var (shop, product) in products)
            {
                Console.WriteLine($"{shop}->");

                foreach (var (prod, price) in product)
                {
                    Console.WriteLine($"Product: {prod}, Price: {price}");
                }        
            }
        }
    }
}
