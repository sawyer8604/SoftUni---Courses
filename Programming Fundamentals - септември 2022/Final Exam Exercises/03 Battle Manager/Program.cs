using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _03_Battle_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            Dictionary<string, People> battles = new Dictionary<string, People>();

            while ((input = Console.ReadLine()) != "Results")
            {
                string[] cmdArguments = input.Split(":", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                if (firstCommand == "Add")
                {
                    //Add:{personName}:{health}:{energy}":

                    string personName = cmdArguments[1];

                    int health = int.Parse(cmdArguments[2]);
                    int energy = int.Parse(cmdArguments[3]);

                    if (!battles.ContainsKey(personName))
                    {
                        battles[personName] = new People(health, energy);
                    }
                    else
                    {

                        battles[personName].Health += health;
                        battles[personName].Energy += energy;
                    }



                }
                else if (firstCommand == "Attack")
                {
                    //Attack:{attackerName}:{defenderName}:{damage}":

                    string atachkerName = cmdArguments[1];
                    string defenderName = cmdArguments[2];
                    int damage = int.Parse(cmdArguments[3]);

                    if (battles.ContainsKey(atachkerName) && battles.ContainsKey(defenderName))
                    {
                        battles[defenderName].Health -= damage;

                        if (battles[defenderName].Health <= 0)
                        {
                            Console.WriteLine($"{defenderName} was disqualified!");
                            battles.Remove(defenderName);
                        }
                        battles[atachkerName].Energy -= 1;

                        if (battles[atachkerName].Energy <= 0)
                        {
                            Console.WriteLine($"{atachkerName} was disqualified!");
                            battles.Remove(atachkerName);
                        }
                    }

                }
                else if (firstCommand == "Delete")
                {
                    string userName = cmdArguments[1];

                    if (userName == "All")
                    {
                        battles.Clear();
                    }

                    if (battles.ContainsKey(userName))
                    {
                        battles.Remove(userName);
                    }


                }
            }
            Console.WriteLine($"People count: {battles.Count}");

            foreach (var batle in battles.OrderByDescending(health => health.Value.Health).ThenBy(name => name.Key))
            {
                Console.WriteLine($"{batle.Key} - {batle.Value.Health} - {batle.Value.Energy}");

            }
        }

        public class People
        {
            public People(int health, int energy)
            {
                Health = health;
                Energy = energy;
            }

            public int Health { get; set; }
            public int Energy { get; set; }

        }
    }
}
