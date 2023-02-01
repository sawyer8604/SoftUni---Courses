using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Barista_Contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> drinks = new Dictionary<string, int>();

            drinks.Add("Cortado", 50);
            drinks.Add("Espresso", 75);
            drinks.Add("Capuccino", 100);
            drinks.Add("Americano", 150);
            drinks.Add("Latte", 200);

            int[] coffee = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> coffeeQueue = new Queue<int>(coffee);

            int[] milk = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> milkStack = new Stack<int>(milk);

            Dictionary<string, int> numberOfDrinks = new Dictionary<string, int>();

            while (true)
            {
                if (!coffeeQueue.Any())
                {
                    break;
                }

                if (!milkStack.Any())
                {
                    break;
                }

                int crrCoffee = coffeeQueue.Peek();
                int crrMilk = milkStack.Peek();
                int sum = crrCoffee + crrMilk;

                bool isEqual = false;

                foreach (var (drink, value) in drinks)
                {
                    if (sum == value)
                    {
                        isEqual = true;
                        if (!numberOfDrinks.ContainsKey(drink))
                        {
                            numberOfDrinks[drink] = 1;
                        }
                        else
                        {
                            numberOfDrinks[drink]++;
                        }

                        coffeeQueue.Dequeue();
                        milkStack.Pop();
                    }

                }

                if (isEqual == false)
                {
                    coffeeQueue.Dequeue();
                    int crrMilkCuantity = milkStack.Peek();
                    milkStack.Pop();
                    crrMilkCuantity -= 5;
                    if(crrMilkCuantity < 0)
                    {
                        crrMilkCuantity = 0;
                    }
                    milkStack.Push(crrMilkCuantity);
                }


            }

            if (coffeeQueue.Count == 0 && milkStack.Count == 0)
            {
                Console.WriteLine("Nina is going to win! She used all the coffee and milk!");
                Console.WriteLine("Coffee left: none");
                Console.WriteLine("Milk left: none");

            }
            else
            {
                Console.WriteLine("Nina needs to exercise more! She didn't use all the coffee and milk!");

                if (coffeeQueue.Count == 0)
                {
                    Console.WriteLine("Coffee left: none");
                }
                else
                {
                    Console.WriteLine($"Coffee left: {string.Join(", ", coffeeQueue)}");
                }

                if (milkStack.Count == 0)
                {
                    Console.WriteLine("Milk left: none");
                }
                else
                {
                    Console.WriteLine($"Milk left: {string.Join(", ", milkStack)}");
                }

            }


            foreach (var (crrDrinks, count) in numberOfDrinks.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{crrDrinks}: {count}");
            }
        }
    }
}
