using _05.StackofStrings;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings customStack = new StackOfStrings();

            Console.WriteLine(customStack.IsEmpty());

            customStack.Push("1");
            customStack.Push("2");
            customStack.Push("3");

            Console.WriteLine(customStack.IsEmpty());

            List<string> elements = Console.ReadLine().Split(" ").ToList();

            customStack.AddRange(elements);
            Console.WriteLine(customStack.IsEmpty());

            Console.WriteLine(string.Join(" ", customStack));
        }
    }
}
