using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._SoftUni_Exam_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, int> users = new SortedDictionary<string, int>();

            Dictionary<string, int> languages = new Dictionary<string, int>();

            string commands;

            while ((commands = Console.ReadLine()) != "exam finished")
            {
                string[] cmdArguments = commands.Split("-", StringSplitOptions.RemoveEmptyEntries);

                string command = cmdArguments[1];

                string username = cmdArguments[0];
               

                if (command != "banned")
                {
                    string language = cmdArguments[1];
                    int points = int.Parse(cmdArguments[2]);

                    if (!users.ContainsKey(username))
                    {
                        users[username] = 0;
                    }
                    if(users[username] < points)
                    {
                        users[username] = points;
                    }
                    
                    if (!languages.ContainsKey(language))
                    {
                        languages[language] = 0;
                    }
                    languages[language]++;

                }
                else
                {
                    users.Remove(username);
                }
            }

            var orderedUsers = users.OrderByDescending(x => x.Value);

            Console.WriteLine($"Results:");

            foreach (var user in orderedUsers)
            {
                Console.WriteLine($"{user.Key} | {user.Value}");
            }

            Console.WriteLine("Submissions:");

            var orderedSLanguages = languages.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var language in orderedSLanguages)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
