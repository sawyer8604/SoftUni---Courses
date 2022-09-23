using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = Console.ReadLine().ToLower();

            numberOfWovels(word);
        }

        private static void numberOfWovels(string word)
        {
            Console.WriteLine(word.Count(vowles => "aouei".Contains(vowles)));
        }
    }
}
