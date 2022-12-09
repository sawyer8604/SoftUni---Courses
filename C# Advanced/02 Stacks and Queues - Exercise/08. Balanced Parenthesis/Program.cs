using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            bool isBalanced = false;

            if (input.Length % 2 == 0)
            {


                foreach (char ch in input)
                {
                    stack.Push(ch);

                    if ((ch == ')' || ch == '}' || ch == ']') && stack.Count > 1)
                    {
                        char secondElement = stack.Pop();

                        char crrElement = stack.Pop();

                        if ((crrElement == '(' && secondElement == ')') || (crrElement == '[' && secondElement == ']') || (crrElement == '{' && secondElement == '}'))
                        {
                            isBalanced = true;
                        }
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }

                }
            }

            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
