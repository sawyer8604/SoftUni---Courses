using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(?<det>[\:]{2})(?<first>[A-Z]{1}[a-z]{2,})(\k<det>)|(?<de>[\*]{2})(?<second>[A-Z]{1}[a-z]{2,})(\k<de>)";

            string input = Console.ReadLine();

            Regex regex = new Regex(patern);

            MatchCollection matches = regex.Matches(input);

            int coolSum = 1;

            foreach (char ch in input)
            {
                if(char.IsDigit(ch))
                {
                    string crrChar = ch.ToString();
                    coolSum *= int.Parse(crrChar);
                }
                    
            }
            List<string> coolList = new List<string>();
            

            foreach (Match match in matches)
            {
                string word = match.Value;

                int crrSum = 0;

                foreach (var letter in word)
                {
                    if(char.IsLetter(letter))
                    {
                        crrSum += (int)letter;
                    }
                }
                if(crrSum >= coolSum)
                {
                    coolList.Add(word);
                }

            }

            Console.WriteLine($"Cool threshold: {coolSum}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(String.Join(Environment.NewLine, coolList));
        }
    }
}
