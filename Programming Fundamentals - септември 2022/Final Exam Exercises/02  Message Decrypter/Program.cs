using System;
using System.Text.RegularExpressions;

namespace _02__Message_Decrypter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"^(?<d>[\$\%])(?<message>[A-Z][a-z]{2,})(\k<d>): \[(?<first>[0-9]+)\]\|\[(?<second>[0-9]+)\]\|\[(?<third>[0-9]+)\]\|$";

            Regex regex = new Regex(patern);

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if(match.Success)
                {
                    string message = match.Groups["message"].Value;
                    int firstNum = int.Parse(match.Groups["first"].Value);
                    int secondNum = int.Parse(match.Groups["second"].Value);
                    int thirdNum = int.Parse(match.Groups["third"].Value);

                    char firstNumAsChar = (char)firstNum;
                    char secondNumAsChar = (char)secondNum;
                    char thirdNumAsChar = (char)thirdNum;

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
