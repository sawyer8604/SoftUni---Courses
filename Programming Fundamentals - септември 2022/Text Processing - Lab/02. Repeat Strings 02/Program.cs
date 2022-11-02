using System;
using System.Text;

namespace _02._Repeat_Strings_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ");

            StringBuilder newWord = new StringBuilder();

            foreach (string word in words)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    newWord.Append(word).ToString();
                }

            }
            Console.WriteLine(newWord);
        }
    }
}
