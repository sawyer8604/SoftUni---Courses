using System;
using System.Text.RegularExpressions;

namespace _02_Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"^(?<d>[\D\W\S]+)>(?<numbers>[0-9]+)\|(?<low>[a-z]+)\|(?<uper>[A-Z]+)\|(?<symbols>[^\<\>]+)<(\k<d>)$";

            int numberOfLines = int.Parse(Console.ReadLine());
            Regex regex = new Regex(patern);

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if(match.Success)
                {
                    string numbers = match.Groups["numbers"].Value;
                    string lowerCase = match.Groups["low"].Value;
                    string uperCase = match.Groups["uper"].Value;
                    string symbols = match.Groups["symbols"].Value;

                    Console.WriteLine($"Password: {numbers}{lowerCase}{uperCase}{symbols}");

                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
