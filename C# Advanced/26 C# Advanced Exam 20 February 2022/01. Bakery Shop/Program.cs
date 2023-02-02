using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bakery_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products croissant = new Products(50, 50);
            Products muffin = new Products(40, 60);
            Products baguette = new Products(30, 70);
            Products bagel = new Products(20, 80);

            Dictionary<string, Products> products = new Dictionary<string, Products>();

            products.Add("Croissant", croissant);
            products.Add("Muffin", muffin);
            products.Add("Baguette", baguette);
            products.Add("Bagel", bagel);


            double[] water = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Queue<double> waterQueue = new Queue<double>(water);

            double[] flour = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            Stack<double> flourStack = new Stack<double>(flour);

            Dictionary<string, int> bakedProduct = new Dictionary<string, int>();

            while (true)
            {
                if(!waterQueue.Any())
                {
                    break;
                }
                if (!flourStack.Any())
                {
                    break;
                }

                double crrWater = waterQueue.Peek();
                double crrFlour = flourStack.Peek();

                bool isBaked = false;

                // (16.8 + 25.2 = 42; (16.8 * 100)/42 = 40% water) 
                double sum = crrWater + crrFlour;
                double waterPercent = crrWater * 100 / sum;

                foreach (var (name, value) in products)
                {
                    if (waterPercent == value.Water)
                    {
                        if (!bakedProduct.ContainsKey(name))
                        {
                            bakedProduct[name] = 0;
                        }
                        bakedProduct[name]++;

                        waterQueue.Dequeue();
                        flourStack.Pop();
                        isBaked = true;
                        break;
                    }

                }

                if (isBaked == false)
                {
                    if (!bakedProduct.ContainsKey("Croissant"))
                    {
                        bakedProduct["Croissant"] = 0;
                    }
                    bakedProduct["Croissant"]++;

                    crrFlour = flourStack.Pop();
                    crrFlour -= crrWater;
                    flourStack.Push(crrFlour);
                    waterQueue.Dequeue();
                }


            }
            
            foreach(var (name, count) in bakedProduct.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{name}: {count}");
            }

            if(!waterQueue.Any())
            {
                Console.WriteLine("Water left: None");
            }
            else
            {
                Console.WriteLine($"Water left: {string.Join(", ", waterQueue)}");
            }

            if (!flourStack.Any())
            {
                Console.WriteLine("Flour left: None");
            }
            else
            {
                Console.WriteLine($"Flour left: {string.Join(", ", flourStack)}");
            }
        }
    }

    public class Products
    {
        public Products()
        {

        }
        public Products(double water, double flour)
        {
            Water = water;
            Flour = flour;
        }

        public double Water { get; set; }
        public double Flour { get; set; }
    }
}
