using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').Select(word => word.ToLower()).ToArray();

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if(wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }

            string[] oddCountWords = wordCount
                .Where(w => w.Value % 2 != 0)
                .Select(w => w.Key)
                .ToArray();

            Console.WriteLine(string.Join(" ", oddCountWords));
        }
    }
}
