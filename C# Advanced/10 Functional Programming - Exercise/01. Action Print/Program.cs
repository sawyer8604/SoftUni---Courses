using System;

namespace _01._Action_Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printWord = word => Console.WriteLine(word);

            string[] words = Console.ReadLine().Split(" ");

            foreach (var word in words)
            {
                printWord(word);
            }
        }
    }
}
