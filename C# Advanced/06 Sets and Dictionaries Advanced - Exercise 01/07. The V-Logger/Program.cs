using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> vlogers = new HashSet<string>();

            Dictionary<string, Vloger> people = new Dictionary<string, Vloger>();

            string command;

            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if(cmdArguments.Contains("joined"))
                {
                    string name = cmdArguments[0];

                    vlogers.Add(name);

                }
                else
                {
                    string firstName = cmdArguments[0];
                    string secondName = cmdArguments[2];

                    if(vlogers.Contains(firstName) && vlogers.Contains(secondName) && firstName != secondName)
                    {
                        if(!people.ContainsKey(secondName))
                        {
                            people[secondName] = new Vloger();
                        }
                        people[secondName].Folowres.Add(firstName);

                        if (!people.ContainsKey(firstName))
                        {
                            people[firstName] = new Vloger();
                        }
                        people[firstName].Folowing.Add(secondName);

                    }

                }

            }

            foreach (var item in vlogers)
            {
                if(!people.ContainsKey(item))
                {
                    people[item] = new Vloger();
                }                
            }

            Console.WriteLine($"The V-Logger has a total of {vlogers.Count} vloggers in its logs.");

            int count = 0;

            var sorted = people.OrderByDescending(x => x.Value.Folowres.Count).ThenBy(x => x.Value.Folowing.Count).ToDictionary(k => k.Key, v => v.Value);

            foreach (var vlogger in sorted)
            {
                count++;

                if(count == 1)
                {
                    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Folowres.Count} followers, {vlogger.Value.Folowing.Count} following");

                    foreach (var item in vlogger.Value.Folowres)
                    {
                        Console.WriteLine($"*  {item}");
                    }
                    
                    continue;
                }               

                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Folowres.Count} followers, {vlogger.Value.Folowing.Count} following");
            }
        }

        public class Vloger
        {
            public Vloger()
            {
                Folowres = new SortedSet<string>();
                Folowing = new HashSet<string>();
            }

            public SortedSet<string> Folowres { get; set; }
            public HashSet<string> Folowing { get; set; }

        }
    }
}
