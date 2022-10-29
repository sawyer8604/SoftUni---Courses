using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                
                if(!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(synonym);

            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            } 
        }
    }
}
