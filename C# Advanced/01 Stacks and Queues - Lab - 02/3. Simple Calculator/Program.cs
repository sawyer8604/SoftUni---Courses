using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] expretion = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            Stack<string> stack = new Stack<string>(expretion);

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                char operation = char.Parse(stack.Pop());
                int secondNum = int.Parse(stack.Pop());

                int crrSum = 0;

                if (operation == '+')
                {
                    crrSum = firstNum + secondNum;
                }
                else
                {
                    crrSum = firstNum - secondNum;
                }

                stack.Push(crrSum.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
