using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vloggers> vloggers = new Dictionary<string, Vloggers>();

            HashSet<string> firstList = new HashSet<string>();

            string command;

            while ((command = Console.ReadLine()) != "Statistics")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[1];

                if (firstCommand == "joined")
                {
                    string vloggerName = cmdArguments[0];

                    firstList.Add(vloggerName);

                }
                else if (firstCommand == "followed")
                {
                    string vloggerFollower = cmdArguments[0];
                    string vlogerForFollow = cmdArguments[2];

                    if (firstList.Contains(vloggerFollower) && firstList.Contains(vlogerForFollow))
                    {

                        if (vlogerForFollow == vloggerFollower)
                        {
                            continue;
                        }

                        AddFollowers(vloggers, vlogerForFollow);

                        vloggers[vlogerForFollow].Followers.Add(vloggerFollower);
                        AddFollowing(vloggers, vloggerFollower, vlogerForFollow);

                    }


                }

            }

            AddVlogerWithoutFollowersAndWollowing(vloggers, firstList);

            int count = 0;

            Console.WriteLine($"The V-Logger has a total of {firstList.Count} vloggers in its logs.");

            foreach (var vlogger in vloggers.OrderByDescending(x => x.Value.Followers.Count()).ThenBy(y => y.Value.Following.Count()))
            {
                if (count < 1)
                {
                    count++;

                    Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");

                    foreach (var item in vlogger.Value.Followers)
                    {
                        Console.WriteLine($"*  {item}");
                    }

                    continue;
                }
                count++;

                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value.Followers.Count} followers, {vlogger.Value.Following.Count} following");


            }

        }

         static void AddFollowers(Dictionary<string, Vloggers> vloggers, string vlogerForFollow)
        {
            if (!vloggers.ContainsKey(vlogerForFollow))
            {
                vloggers[vlogerForFollow] = new Vloggers(new SortedSet<string>(), new HashSet<string>());
            }
        }

         static void AddFollowing(Dictionary<string, Vloggers> vloggers, string vloggerFollower, string vlogerForFollow)
        {
            if (!vloggers.ContainsKey(vloggerFollower))
            {
                vloggers[vloggerFollower] = new Vloggers(new SortedSet<string>(), new HashSet<string>());
            }

            vloggers[vloggerFollower].Following.Add(vlogerForFollow);
        }

        static void AddVlogerWithoutFollowersAndWollowing(Dictionary<string, Vloggers> vloggers, HashSet<string> firstList)
        {
            foreach (var name in firstList)
            {
                if (!vloggers.ContainsKey(name))
                {
                    vloggers[name] = new Vloggers(new SortedSet<string>(), new HashSet<string>());
                }



                if (!vloggers.ContainsKey(name))
                {
                    vloggers[name] = new Vloggers(new SortedSet<string>(), new HashSet<string>());
                }


            }
        }

        public class Vloggers
        {
            public Vloggers(SortedSet<string> followers, HashSet<string> following)
            {
                Followers = followers;
                Following = following;
            }

            public SortedSet<string> Followers { get; set; }
            public HashSet<string> Following { get; set; }
        }
    }


}
