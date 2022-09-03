using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int wordLength = word.Length - 1;

            for (int i = wordLength; i >= 0; i--)
            {
                char digit = word[i];
                Console.Write(digit);
            }
        }
    }
}
