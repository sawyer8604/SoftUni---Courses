using System;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            string newWord = string.Empty;

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    newWord += word;
                }

            }
            Console.WriteLine(newWord);
        }
    }
}
