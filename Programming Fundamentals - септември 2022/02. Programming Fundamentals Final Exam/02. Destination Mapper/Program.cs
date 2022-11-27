using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(?<delimiter>[\=\/]{1})(?<place>[A-Z]{1}[A-Za-z]{2,})(\k<delimiter>)";

            string input = Console.ReadLine();

            Regex regex = new Regex(patern);

            MatchCollection matches = regex.Matches(input);

            int points = 0;
            List<string> places = new List<string>();

            foreach (Match match in matches)
            {
                string place = match.Groups["place"].Value;
                places.Add(place);

                points += place.Length;
                
            }
            Console.WriteLine($"Destinations: {string.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
