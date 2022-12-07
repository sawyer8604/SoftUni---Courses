using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char crrElement = input[i];

                if(crrElement =='(')
                {
                    stack.Push(i);
                }

                if(crrElement ==')')
                {
                    stack.Push(i);

                    int lastIndex = stack.Pop();
                    int firsIndex = stack.Pop();

                    for (int j = firsIndex; j <= lastIndex; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }


            }

        }
    }
}
