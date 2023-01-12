using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> participants = new Dictionary<string, int>();

            Dictionary<string, int> submitions = new Dictionary<string, int>();

            string command;

            while ((command = Console.ReadLine()) != "exam finished")
            {
                string[] cmdArguments = command.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArguments[0];

                if (cmdArguments.Length == 2)
                {
                    if(participants.ContainsKey(name))
                    {
                        participants.Remove(name);
                        continue;
                    }
                }
                
                string contest = cmdArguments[1];
                int points = int.Parse(cmdArguments[2]);

                if(!participants.ContainsKey(name))
                {
                    participants[name] = 0;
                }

                if(participants[name] < points)
                {
                    participants[name] = points;
                }
                

                if (!submitions.ContainsKey(contest))
                {
                    submitions[contest] = 0;
                }
                submitions[contest]++;
            }

            var orderedParticipants = participants.OrderByDescending(points => points.Value).ThenBy(name => name.Key);

            Console.WriteLine("Results:");

            foreach (var (username, points) in orderedParticipants)
            {
                Console.WriteLine($"{username} | {points}");
            }

            var orderedSubmitions = submitions.OrderByDescending(count => count.Value).ThenBy(name => name.Key);

            Console.WriteLine("Submissions:");

            foreach (var (language, submissionsCount) in orderedSubmitions)
            {
                Console.WriteLine($"{language} - {submissionsCount}");
            }
        }
    }
}
