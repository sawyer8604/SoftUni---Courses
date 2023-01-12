using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> examAndPass = new Dictionary<string, string>();

            Dictionary<string, Dictionary<string, int>> contestant = new Dictionary<string, Dictionary<string, int>>();

            string firstCommand;

            while ((firstCommand = Console.ReadLine()) != "end of contests")
            {
                string[] firstCmdArguments = firstCommand.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string examName = firstCmdArguments[0];
                string pass = firstCmdArguments[1];

                examAndPass[examName] = pass;
                
            }

            string secondCommand;

            while ((secondCommand = Console.ReadLine()) != "end of submissions")
            {
                string[] secondCmdArguments = secondCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries);


                string examName = secondCmdArguments[0];
                string pass = secondCmdArguments[1];
                string name = secondCmdArguments[2];
                int points = int.Parse(secondCmdArguments[3]);

                if(examAndPass.ContainsKey(examName) && examAndPass[examName] == pass)
                {
                    if(!contestant.ContainsKey(name))
                    {
                        contestant[name] = new Dictionary<string, int>();
                    }

                    if (!contestant[name].ContainsKey(examName))
                    {
                        contestant[name][examName] = 0;
                    }

                    if(contestant[name][examName] < points)
                    {
                        contestant[name][examName] = points;
                    }
                    
                }

            }

            string bestCandidate = contestant.OrderByDescending(x => x.Value.Values.Sum()).FirstOrDefault().Key;

            int bestCandidatePoints = contestant[bestCandidate].Values.Sum();


            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidatePoints} points.");

            Dictionary<string, Dictionary<string, int>> orderedContestant = contestant.OrderBy(name => name.Key).ToDictionary(k => k.Key, v => v.Value);

            Console.WriteLine("Ranking:");

            foreach (var users in orderedContestant)
            {
                Console.WriteLine(users.Key);

                foreach (var (contest, points) in users.Value.OrderByDescending(x =>x.Value))
                {
                    Console.WriteLine($"#  {contest} -> {points}");
                }
            }
        }
    }
}
