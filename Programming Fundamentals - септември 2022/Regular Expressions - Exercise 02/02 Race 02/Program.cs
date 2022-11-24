using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string participantsPattern = @"([A-Za-z])";
            string distancePatern = @"(\d)";
            Regex participantsRegex = new Regex(participantsPattern);
            Regex distanceRegex = new Regex(distancePatern);



            List<string> listOfNames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var dictionary = new Dictionary<string, int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                int sumDistance = 0;

                var names = new StringBuilder();

                MatchCollection namesMatches = participantsRegex.Matches(input);
                MatchCollection distanceMatches = distanceRegex.Matches(input);

                foreach (Match name1 in namesMatches)
                {
                    names.Append(name1);
                }

                string name = names.ToString();

                foreach (Match num in distanceMatches)
                {
                    sumDistance += int.Parse(num.Value);
                }

                if (listOfNames.Contains(name))
                {
                    if (!dictionary.ContainsKey(name))
                    {
                        dictionary[name] = 0;
                    }
                    dictionary[name] += sumDistance;
                }


            }


            int count = 1;

            foreach (var participant in dictionary.OrderByDescending(key => key.Value))
            {
                string place = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count}{place} place: {participant.Key}");

                count++;

                if (count >= 4)
                {
                    break;
                }
            }


        }
    }
}