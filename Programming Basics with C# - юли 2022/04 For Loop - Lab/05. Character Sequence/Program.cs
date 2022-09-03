using System;

namespace _05._Character_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int wordLength = word.Length;

            for (int i = 0; i < wordLength; i++)
            {
                char letter = word[i];

                Console.WriteLine(letter);
            }
        }
    }
}
