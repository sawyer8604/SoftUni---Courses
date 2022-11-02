using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();

            string word = Console.ReadLine();

            while (word.Contains(wordToRemove))
            {
                word = word.Replace(wordToRemove, string.Empty);

            }

            Console.WriteLine(word);
        }
    }
}
