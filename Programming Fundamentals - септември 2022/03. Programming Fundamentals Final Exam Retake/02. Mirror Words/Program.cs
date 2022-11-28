using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(?<del>[\@\#]{1})(?<first>[A-Za-z]{3,})(\k<del>{2})(?<second>[A-Za-z]{3,})(\k<del>{1})";

            string input = Console.ReadLine();

            Regex regex = new Regex(patern);

            MatchCollection matches = regex.Matches(input);

            List<string> equal = new List<string>();

            if (!regex.IsMatch(input))
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine($"No mirror words!");
                return;
            }
            else
            {
               
                foreach (Match match in matches)
                {
                    string word = match.Groups["first"].Value;
                    string reversedWord = match.Groups["second"].Value;

                    char[] reversedString = reversedWord.ToCharArray();
                    Array.Reverse(reversedString);
                    string seconfWord = new string(reversedString);

                    if (word == seconfWord)
                    {
                        equal.Add($"{word} <=> {reversedWord}");
                    }
                    
                }
                Console.WriteLine($"{matches.Count} word pairs found!");

            }
                       
            

            if (equal.Count == 0)
            {
                Console.WriteLine($"No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", equal));
            }
        }
    }
}
