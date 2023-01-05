using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string command;

            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0].ToLower();

                switch (firstCommand)
                {
                    case "add":

                        int firstNum = int.Parse(cmdArguments[1]);
                        int secondNum = int.Parse(cmdArguments[2]);

                        stack.Push(firstNum);
                        stack.Push(secondNum);

                        break;

                    case "remove":

                        int removeCount = int.Parse(cmdArguments[1]);

                        if (removeCount <= stack.Count)
                        {
                            for (int i = 0; i < removeCount; i++)
                            {
                                stack.Pop();
                            }
                        }

                        break;
                }

            }

            int sum = stack.Sum();

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
