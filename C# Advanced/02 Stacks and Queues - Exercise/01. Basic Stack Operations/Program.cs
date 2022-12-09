using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int numberToPush = numbers[0];
            int numberToPop = numbers[1];
            int numberToCheck = numbers[2];

            int[] collection = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stack= new Stack<int>();

            for (int i = 0; i < numberToPush; i++)
            {
                stack.Push(collection[i]);
            }

            if(numberToPop > stack.Count)
            {
                numberToPop = stack.Count;
            }

            for (int i = 0; i < numberToPop; i++)
            {

                stack.Pop();
            }

            if(!stack.Any())
            {
                Console.WriteLine(0);
            }
            else if(stack.Contains(numberToCheck))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }


        }
    }
}
