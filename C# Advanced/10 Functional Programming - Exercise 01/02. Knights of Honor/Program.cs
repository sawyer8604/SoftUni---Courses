using System;

namespace _02._Knights_of_Honor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");

            Action<string[], string> printName = (names, title) =>
            {
                Console.WriteLine(title + string.Join(Environment.NewLine + title, names));
            };

            printName(names, "Sir ");

        }
    }
}
