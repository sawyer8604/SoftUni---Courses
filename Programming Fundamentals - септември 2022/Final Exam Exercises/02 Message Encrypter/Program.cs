using System;
using System.Text.RegularExpressions;

namespace _02_Message_Encrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(?<d>[\*\@])(?<message>[A-Z][a-z]{2,})(\k<d>): \[(?<first>[A-z]+)\]\|\[(?<second>[A-z]+)\]\|\[(?<third>[A-z]+)\]\|";

            int numberOfLines = int.Parse(Console.ReadLine());

            Regex regex = new Regex(patern);


            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string message = match.Groups["message"].Value;
                    char firstNumAsChar = char.Parse(match.Groups["first"].Value);
                    char secondNumAsChar = char.Parse(match.Groups["second"].Value);
                    char thirdNumAsChar = char.Parse(match.Groups["third"].Value);

                    int firstNum = (int)(firstNumAsChar);
                    int secondNum = (int)(secondNumAsChar);
                    int thirdNum = (int)(thirdNumAsChar);

                    Console.WriteLine($"{message}: {firstNumAsChar}{secondNumAsChar}{thirdNumAsChar}");

                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
