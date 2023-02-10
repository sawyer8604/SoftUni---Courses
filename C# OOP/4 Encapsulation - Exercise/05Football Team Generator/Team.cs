using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05Football_Team_Generator
{
    public class Team
    {
        List<Player> players;

        private string name;

        public Team(string name)
        {
            Name = name;
            players = new List<Player>();
        }

        public IReadOnlyCollection<Player> Players => players;

        public int Count => players.Count;
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.nameShouldNotBeEmpty));
                }
                name = value;
            }
        }
        public double Rating => Math.Round(players.Average(x => x.SkillLevel));
        public void AddPlayer(Player player)
        {
            players.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            players.Remove(player);
        }
    }
}
