using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines =int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfLines; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int firstCommand = commands[0];

                if(firstCommand == 1)
                {
                    int numberToPush = commands[1];

                    stack.Push(numberToPush);
                }
                else if(firstCommand == 2)
                {
                    if(stack.Any())
                    {
                        stack.Pop();
                    }
                    
                }
                else if(firstCommand == 3)
                {
                    if(stack.Any())
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if(firstCommand == 4)
                {
                    if (stack.Any())
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
