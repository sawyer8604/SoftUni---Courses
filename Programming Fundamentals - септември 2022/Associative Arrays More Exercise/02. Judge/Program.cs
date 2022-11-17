using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();

            SortedDictionary<string, Dictionary<string, int>> individualStatistics = new SortedDictionary<string, Dictionary<string, int>>();

            string input;

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] inputArguments = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string userName = inputArguments[0];
                string contest = inputArguments[1];
                int points = int.Parse(inputArguments[2]);

                if (!users.ContainsKey(contest))
                {
                    users[contest] = new Dictionary<string, int>();
                }

                if (!users[contest].ContainsKey(userName))
                {
                    users[contest][userName] = points;

                }
                else
                {
                    if (users[contest][userName] < points)
                    {
                        users[contest][userName] = points;
                    }
                }

                if (!individualStatistics.ContainsKey(userName))
                {
                    individualStatistics.Add(userName, new Dictionary<string, int>());
                    individualStatistics[userName].Add(contest, points);
                }
                else
                {


                    if (!individualStatistics[userName].ContainsKey(contest))
                    {
                        individualStatistics[userName][contest] = points;
                    }
                    else
                    {

                        if (individualStatistics[userName][contest] < points)
                        {
                            individualStatistics[userName][contest] = points;
                        }
                    }
                }



            }




            foreach (var user in users)
            {
                int position1 = 0;

                Console.WriteLine($"{user.Key}: {user.Value.Count} participants");

                foreach (var (practicipant, points) in user.Value.OrderByDescending(point => point.Value).ThenBy(name => name.Key))
                {
                    position1++;
                    Console.WriteLine($"{position1}. {practicipant} <::> {points}");
                }
            }




            var filterIndivDic = new Dictionary<string, int>();

            int sum = 0;

            foreach (var item in individualStatistics)
            {
                foreach (var items in item.Value)
                {
                    sum += items.Value;
                }
                filterIndivDic.Add(item.Key, sum);
                sum = 0;
            }

            filterIndivDic = filterIndivDic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);

            int position = 1;
            Console.WriteLine("Individual standings:");
            foreach (var item in filterIndivDic)
            {
                Console.WriteLine($"{position}. {item.Key} -> {item.Value}");
                position++;
            }
        }
    }
}
