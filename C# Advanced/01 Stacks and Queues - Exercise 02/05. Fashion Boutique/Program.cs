using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

            int capacityOfRack = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(clothes);

            int crrCapacity = capacityOfRack;

            int numberOfRack = 0;

            while (stack.Any())
            {
                int crrClothes = stack.Peek();

                if(crrCapacity - crrClothes >= 0)
                {
                    crrCapacity -= crrClothes;
                    stack.Pop();
                }
                else
                {
                    crrCapacity = capacityOfRack;
                    numberOfRack++;

                }
            }

            if (crrCapacity < capacityOfRack)
            {
                numberOfRack++;
            }
            Console.WriteLine(numberOfRack);
        }
    }
}
