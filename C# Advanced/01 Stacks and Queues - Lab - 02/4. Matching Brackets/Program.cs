using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indices = new Stack<int>();

            string subString = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == '(')
                {
                    indices.Push(i);
                }

                if(symbol == ')')
                {
                    int endIndex = i;
                    int beginIndex = indices.Pop();

                    subString = input.Substring(beginIndex, endIndex - beginIndex + 1);

                    Console.WriteLine(subString);
                }
                
            }            
            
        }
    }
}
