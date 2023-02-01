using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Energy_Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int maximumCaffeine = 0;

            int[] caffeine = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> caffeinestack = new Stack<int>(caffeine);

            int[] drinks = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> drinkQueue = new Queue<int>(drinks);

            int totalCaffeine = 0;

            while (totalCaffeine < 300)
            {
                if(!caffeinestack.Any())
                { break; }

                if (!drinkQueue.Any())
                { break; }

                int crrCaffeine = caffeinestack.Peek() * drinkQueue.Peek();

                maximumCaffeine = 300 - totalCaffeine;


                if (crrCaffeine + totalCaffeine <= 300)
                {
                    totalCaffeine += crrCaffeine;
                    caffeinestack.Pop();
                    drinkQueue.Dequeue();
                }
                else 
                {
                    caffeinestack.Pop();
                    int crrDrink = drinkQueue.Dequeue();
                    drinkQueue.Enqueue(crrDrink);
                    totalCaffeine -= 30;

                    if(totalCaffeine < 0 )
                    {
                        totalCaffeine = 0;
                    }
                }

            }

            if(drinkQueue.Any())
            {
                Console.WriteLine($"Drinks left: {string.Join(", ", drinkQueue)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {totalCaffeine} mg caffeine.");
        }
    }
}
