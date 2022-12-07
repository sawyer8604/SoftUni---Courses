using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input= Console.ReadLine().Split(" ").ToArray();

            input = input.Reverse().ToArray();

            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string symbol = stack.Pop().ToString();
                int secondNum = int.Parse(stack.Pop());

                int crrSum = 0;

                if(symbol == "-")
                {
                    crrSum = firstNum - secondNum;
                }

                if (symbol == "+")
                {
                    crrSum = firstNum + secondNum;
                }
                
                stack.Push(crrSum.ToString());

            }
            Console.WriteLine(stack.Pop());
        }
    }
}
