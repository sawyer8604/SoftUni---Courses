using System;
using System.Linq;

namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWord = Console.ReadLine().Split(", ");

            string words = Console.ReadLine();

            foreach (var word in bannedWord)
            {
                string replacedWordWithAsteriks = new string('*', word.Length);

                while (words.Contains(word))
                {
                    words = words.Replace(word, replacedWordWithAsteriks);
                }

            }
            Console.WriteLine(words);
        }
    }
}
