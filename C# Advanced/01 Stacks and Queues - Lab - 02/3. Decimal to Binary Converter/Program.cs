using System;
using System.Collections.Generic;

namespace _3._Decimal_to_Binary_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Stack<int> binaryStack = new Stack<int>();

            if(number == 0)
            {
                Console.WriteLine(0);
                return;
            }

            while (number != 0)
            {
                if(number % 2 == 0)
                {
                    binaryStack.Push(0);
                }
                else
                {
                    binaryStack.Push(number % 2);
                }
                number /= 2;
            }

            Console.WriteLine(string.Join("", binaryStack));
        }
    }
}
