using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 x – Push the element x into the stack.
            //2 – Delete the element present at the top of the stack.
            //3 – Print the maximum element in the stack.
            //4 – Print the minimum element in the stack.


            int numberOfCommands = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                int[] crrCommands = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int command = crrCommands[0];

                switch (command)
                {
                    case 1:

                        int numToPush = crrCommands[1];
                        stack.Push(numToPush);

                        break;

                        case 2:

                        stack.Pop();

                        break;

                        case 3:
                        if(stack.Any())
                        {
                            int maxElement = stack.Max();
                            Console.WriteLine(maxElement);
                        }
                        break;

                        case 4:
                        if (stack.Any())
                        {
                            int minElement = stack.Min();
                            Console.WriteLine(minElement);
                        }
                        break;
                }
                
            }
            if(stack.Any())
            {
                Console.WriteLine(string.Join(", ", stack));
            }
            
        }
    }
}
