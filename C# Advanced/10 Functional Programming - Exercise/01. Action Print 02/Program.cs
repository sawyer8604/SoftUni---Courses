using System;

namespace _01._Action_Print_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printName = name => Console.WriteLine(string.Join(Environment.NewLine, name));

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printName(names);
        }
    }
}
