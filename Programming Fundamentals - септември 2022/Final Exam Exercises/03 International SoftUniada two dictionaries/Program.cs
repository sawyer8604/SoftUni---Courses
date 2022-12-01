using System;
using System.Collections.Generic;
using System.Linq;

namespace InternationalSoftUniada
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> contestantsByCountry = new Dictionary<string, List<string>>();
            Dictionary<string, int> contestantsByPoints = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }

                string[] contestantInput = input.Split(" -> ");
                string contestantCounrty = contestantInput[0];
                string contestantName = contestantInput[1];
                int contestantPoints = int.Parse(contestantInput[2]);

                if (!contestantsByCountry.ContainsKey(contestantCounrty))
                {
                    contestantsByCountry[contestantCounrty] = new List<string>();
                }

                if (!contestantsByCountry[contestantCounrty].Contains(contestantName))
                {
                    contestantsByCountry[contestantCounrty].Add(contestantName);
                    contestantsByPoints[contestantName] = 0;
                }

                contestantsByPoints[contestantName] += contestantPoints;
            }

            int SumContestantsPoints(KeyValuePair<string, List<string>> cty)
            {
                int points = 0;
                foreach (var contestant in cty.Value)
                {
                    points += contestantsByPoints[contestant];
                }

                return points;
            }

            foreach (var country in contestantsByCountry.OrderByDescending(SumContestantsPoints))
            {
                Console.WriteLine($"{country.Key}: {SumContestantsPoints(country)}");
                foreach (var contestant in country.Value)
                {
                    Console.WriteLine($" -- {contestant} -> {contestantsByPoints[contestant]}");
                }
            }
        }
    }
}