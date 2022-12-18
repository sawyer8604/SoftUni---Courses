using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            SortedDictionary<string, Dictionary<string, int>> candidates = new SortedDictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] inputArguments = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string contest = inputArguments[0];
                string password = inputArguments[1];

                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = password;
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "end of submissions")
            {
                string[] cmdArguments = command.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = cmdArguments[0];
                string password = cmdArguments[1];
                string userName = cmdArguments[2];
                int points = int.Parse(cmdArguments[3]);

                if (contests.ContainsKey(contest) && contests[contest] == password)
                {
                    
                    if (!candidates.ContainsKey(userName))
                    {
                        candidates[userName] = new Dictionary<string, int>();
                    }

                    if (!candidates[userName].ContainsKey(contest))
                    {
                        candidates[userName][contest] = 0;
                    }


                    if (candidates[userName][contest] < points)
                    {
                        candidates[userName][contest] = points;
                    }

                }
            }


            string bestCandidate = candidates.OrderByDescending(x => x.Value.Values.Sum()).First().Key;

            int bestCandidatesPoints = candidates[bestCandidate].Values.Sum();

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidatesPoints} points.");

            Console.WriteLine("Ranking:");

            foreach (var candidate in candidates)
            {
                Console.WriteLine($"{candidate.Key}");

                foreach (var item in candidate.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }


        }


    }
}
