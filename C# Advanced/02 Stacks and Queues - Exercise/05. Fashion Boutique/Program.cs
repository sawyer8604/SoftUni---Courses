using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberOfClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacity = int.Parse(Console.ReadLine());

            int rack = 1;

            Stack<int> stack = new Stack<int>(numberOfClothes);
            int sum = 0;

            if (capacity <= 0)
            {
                return;
            }

            if (stack.Count <= 0 || stack.Any(x => x < 0))
            {
                return;
            }

            while (stack.Any())
            {

                sum += stack.Peek();

                if (sum <= capacity)
                {

                    stack.Pop();

                }
                else
                {
                    rack++;

                    sum = 0;
                }

            }


            Console.WriteLine(rack);


        }
    }
}
