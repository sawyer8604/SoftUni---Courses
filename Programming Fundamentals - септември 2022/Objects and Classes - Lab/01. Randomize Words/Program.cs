using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];

                int randomIndex = random.Next(words.Length);

                words[i] = words[randomIndex];

                words[randomIndex] = currentWord;

            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
