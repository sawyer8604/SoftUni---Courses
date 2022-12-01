using System;
using System.Collections.Generic;
using System.Linq;

namespace InternationalSoftUniada
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> contestantsByCountry = new Dictionary<string, Dictionary<string, int>>();
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
                    contestantsByCountry[contestantCounrty] = new Dictionary<string, int>();
                }

                if (!contestantsByCountry[contestantCounrty].ContainsKey(contestantName))
                {
                    contestantsByCountry[contestantCounrty][contestantName] = 0;
                }

                contestantsByCountry[contestantCounrty][contestantName] += contestantPoints;
            }

            foreach (var (country, contestants) in contestantsByCountry.OrderByDescending(cty => cty.Value.Sum(c => c.Value)))
            {
                Console.WriteLine($"{country}: {contestants.Sum(c => c.Value)}");
                foreach (var (name, points) in contestants)
                {
                    Console.WriteLine($" -- {name} -> {points}");
                }
            }
        }
    }
}