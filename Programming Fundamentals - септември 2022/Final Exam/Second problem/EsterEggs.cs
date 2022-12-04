using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Second_problem
{
    internal class EsterEggs
    {
        static void Main(string[] args)
        {
            string patern = @"([\@\#]+)(?<colour>[a-z]{3,})([\@\#]+)([^A-Za-z0-9]*)([\/]+)(?<amount>[0-9]+)([\/]+)";

            string input = Console.ReadLine();

            Regex regex = new Regex(patern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string colur = match.Groups["colour"].Value;

                string countOfEggs = match.Groups["amount"].Value;

                Console.WriteLine($"You found {countOfEggs} {colur} eggs!");

            }
        }
    }
}
