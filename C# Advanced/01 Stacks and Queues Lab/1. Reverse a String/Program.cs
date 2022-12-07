using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);

            // OR

            //Stack<char> stack = new Stack<char>();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    char crrChar = input[i];

            //    stack.Push(crrChar);

            //}

            while (stack.Count > 0)
            {
                Console.Write($"{stack.Pop()}");
            }              
               

        }
    }
}
