using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_1_Concert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input;
            
            Dictionary<string, List<string>> members = new Dictionary<string, List<string>>();

            Dictionary<string, int> times = new Dictionary<string, int>();

            int totalTimes = 0;

            while ((input = Console.ReadLine()) != "start of concert")
            {
                string[] arguments = input.Split("; ");

                string firtsCommand = arguments[0];

                switch (firtsCommand)
                {
                    case "Add":

                        string band = arguments[1];

                        List<string> secondCommand = arguments[2].Split(", ").ToList();

                        if(!members.ContainsKey(band))
                        {
                            members[band] = new List<string>();
                            
                        }

                        for (int i = 0; i < secondCommand.Count; i++)
                        {
                            
                            string currentBandName = secondCommand[i];

                            if (!members[band].Contains(currentBandName))
                            {
                                members[band].Add(currentBandName);
                            }

                        }


                        break;

                    case "Play":

                        string bandName = arguments[1];

                        int time = int.Parse(arguments[2]);

                        totalTimes += time;

                        if (!times.ContainsKey(bandName))
                        {
                            times[bandName] = time;
                            continue;
                        }
                        times[bandName] += time;

                        break;

                }
            }

            string finalBandName = Console.ReadLine();


            Console.WriteLine($"Total time: {totalTimes}");

            foreach (var time in times.OrderByDescending(t => t.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{time.Key} -> {time.Value}");
            }


            Console.WriteLine(finalBandName);

            foreach (var member in members)
            {
                if(member.Key == finalBandName)
                {
                    foreach (var crrMember in member.Value)
                    {
                        Console.WriteLine($"=> {crrMember}");
                    }
                }
                
            }
        }
    }
}
