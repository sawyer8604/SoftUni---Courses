using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string commands;

            while ((commands = Console.ReadLine()).ToLower() != "end")
            {
                string[] cmdArguments = commands.Split();

                string firstCommand = cmdArguments[0].ToLower();

                if(firstCommand == "add")
                {
                    int firstNum = int.Parse(cmdArguments[1]);
                    int secondNum = int.Parse(cmdArguments[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if(firstCommand == "remove")
                {
                    int numberToRemove = int.Parse(cmdArguments[1]);

                    if(numberToRemove <= stack.Count)                    
                    {
                        for (int i = 0; i < numberToRemove; i++)
                        {
                            stack.Pop();
                        }

                    }                    

                }
            }

            int sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
