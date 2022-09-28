using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);

            }
            products.Sort();
            int counter = 0;
            foreach (string product in products)
            {
                counter++;
                Console.WriteLine($"{counter}.{product}");
            }
            
        }
    }
}
