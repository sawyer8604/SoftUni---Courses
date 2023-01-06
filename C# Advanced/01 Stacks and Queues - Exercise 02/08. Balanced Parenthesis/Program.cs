using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            bool isBalanced = false;

            if (parentheses.Length <= 1)
            {
                Console.WriteLine("NO");
                return;
            }
            if (parentheses.Length % 2 == 0)
            {
                foreach (var crrSymbol in parentheses)
                {
                    if (crrSymbol == '(' || crrSymbol == '{' || crrSymbol == '[' || crrSymbol == ' ')
                    {
                        stack.Push(crrSymbol);

                    }

                    else if ((crrSymbol == ')' || crrSymbol == '}' || crrSymbol == ']') && stack.Any())
                    {
                        char symbol = stack.Pop();

                        if ((symbol == '(' && crrSymbol == ')')
                            || (symbol == '[' && crrSymbol == ']')
                            || (symbol == '{' && crrSymbol == '}'))
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
