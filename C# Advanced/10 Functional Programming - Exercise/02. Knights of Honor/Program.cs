using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[], string> printName = (names, word) => 
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"{word} {name}");
                }
            };

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printName(input, "Sir");
        }
    }
}
