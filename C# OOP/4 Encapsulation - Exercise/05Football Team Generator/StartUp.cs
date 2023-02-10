using System;
using System.Collections.Generic;
using System.Linq;

namespace _05Football_Team_Generator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {

                try
                {
                    string[] cmdArguments = command.Split(';');
                    string firstCommand = cmdArguments[0];

                    if (firstCommand == "Team")
                    {
                        string teamName = cmdArguments[1];

                        Team team = new Team(teamName);
                        teams.Add(team);
                    }
                    else if (firstCommand == "Add")
                    {
                        string teamName = cmdArguments[1];
                        string playerName = cmdArguments[2];
                        int endurance = int.Parse(cmdArguments[3]);
                        int sprint = int.Parse(cmdArguments[4]);
                        int dribble = int.Parse(cmdArguments[5]);
                        int passing = int.Parse(cmdArguments[6]);
                        int shooting = int.Parse(cmdArguments[7]);

                        Team crrTeam = teams.FirstOrDefault(x => x.Name == teamName);
                        if (crrTeam == null)
                        {
                            throw new ArgumentException(string.Format(ExeptionMessages.missingTeam, teamName));
                        }
                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        crrTeam.AddPlayer(player);
                    }
                    else if (firstCommand == "Remove")
                    {
                        string teamName = cmdArguments[1];
                        string playerName = cmdArguments[2];
                        Team crrTeam = teams.FirstOrDefault(x => x.Name == teamName);
                        Player crrPlayer = crrTeam.Players.FirstOrDefault(x => x.Name == playerName);
                        if (crrPlayer == null)
                        {
                            throw new ArgumentException(string.Format(ExeptionMessages.missingPlayer, playerName, teamName));
                        }

                        crrTeam.RemovePlayer(crrPlayer);
                    }
                    else if (firstCommand == "Rating")
                    {
                        string teamName = cmdArguments[1];

                        Team crrTeam = teams.FirstOrDefault(x => x.Name == teamName);

                        if (crrTeam.Count == 0)
                        {
                            Console.WriteLine($"{teamName} - 0");
                        }
                        else
                        {
                            
                            Console.WriteLine($"{teamName} - {crrTeam.Rating}");
                        }
                       
                    }
                }
                catch (Exception ae)
                {

                    Console.WriteLine(ae.Message);
                }

            }

        }
    }
}
