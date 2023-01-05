using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reversedChars = new Stack<char>();

            // or Stack<char> stack = new Stack<char>(input);

            foreach (var ch in input)
            {
                reversedChars.Push(ch);
            }

            StringBuilder sb = new StringBuilder();

            while (reversedChars.Any())
            {
                sb.Append(reversedChars.Pop());
            }

            Console.WriteLine(sb);
        }
    }
}
