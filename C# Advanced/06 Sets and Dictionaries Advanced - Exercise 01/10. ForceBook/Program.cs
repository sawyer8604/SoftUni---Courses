using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ForceBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, SortedSet<string>> forceBook = new SortedDictionary<string, SortedSet<string>>();

            string command;
            while ((command = Console.ReadLine()) != "Lumpawaroo")
            {               

                if (command.Contains('|'))
                {
                    string[] cmdArguments = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                    string side = cmdArguments[0];
                    string user = cmdArguments[1];

                    if (!forceBook.Values.Any(u => u.Contains(user)))
                    {
                        if (!forceBook.ContainsKey(side))
                        {
                            forceBook.Add(side, new SortedSet<string>());
                        }

                        forceBook[side].Add(user);
                    }
                }
                else
                {
                    string[] tokens = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string side = tokens[1];
                    string user = tokens[0];

                    foreach (var sideUsers in forceBook)
                    {
                        if (sideUsers.Value.Contains(user))
                        {
                            sideUsers.Value.Remove(user);
                            break;
                        }
                    }

                    if (!forceBook.ContainsKey(side))
                    {
                        forceBook.Add(side, new SortedSet<string>());
                    }

                    forceBook[side].Add(user);

                    Console.WriteLine($"{user} joins the {side} side!");
                }
            }

            var orderedSidesUsers = forceBook.OrderByDescending(s => s.Value.Count);

            foreach (var sideUsers in orderedSidesUsers)
            {
                if (sideUsers.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {sideUsers.Key}, Members: {sideUsers.Value.Count}");

                    foreach (var user in sideUsers.Value)
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }
    }
}