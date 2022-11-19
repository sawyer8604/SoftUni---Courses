using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> challengers = new Dictionary<string, Dictionary<string, int>>();

            string input;
            string player;
            string position;
            int skill;

            while ((input = Console.ReadLine()) != "Season end")
            {
                string[] inputArguments = input.Split(" ");


                if (inputArguments[1] == "->")
                {
                    inputArguments = input.Split(" -> ");

                    player = inputArguments[0];
                    position = inputArguments[1];
                    skill = int.Parse(inputArguments[2]);


                    if (!challengers.ContainsKey(player))
                    {
                        challengers[player] = new Dictionary<string, int>();
                    }

                    if (!challengers[player].ContainsKey(position))
                    {
                        challengers[player][position] = skill;
                    }

                    if (challengers[player][position] < skill)
                    {
                        challengers[player][position] = skill;

                    }

                }
                else
                {
                    string playerOne = inputArguments[0];

                    string playerTwo = inputArguments[2];

                    if (challengers.ContainsKey(playerOne) && challengers.ContainsKey(playerTwo))
                    {
                        string playerToRemove = "";

                        foreach (var play1 in challengers[playerOne])
                        {

                            foreach (var play2 in challengers[playerTwo])
                            {
                                if (play1.Key == play2.Key)
                                {
                                    if (challengers[playerOne].Values.Sum() > challengers[playerTwo].Values.Sum())
                                    {
                                        playerToRemove = playerTwo;
                                    }
                                    else if (challengers[playerOne].Values.Sum() < challengers[playerTwo].Values.Sum())
                                    {
                                        playerToRemove = playerOne;
                                    }

                                }
                            }
                        }
                        challengers.Remove(playerToRemove);

                    }
                }

            }

            foreach (var (currPlayer, crrPosition) in challengers.OrderByDescending(skill => skill.Value.Values.Sum()).ThenBy(name => name.Key))
            {
                int totalSkill = crrPosition.Values.Sum();

                Console.WriteLine($"{currPlayer}: {totalSkill} skill");

                foreach (var item in crrPosition.OrderByDescending(skill => skill.Value).ThenBy(position => position.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }

            }

        }
    }
}
