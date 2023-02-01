using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;

        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            players = new List<Player>();
        }

        public string Name { get; private set; }
        public int OpenPositions { get; private set; }
        public char Group { get; private set; }

        public IReadOnlyCollection<Player> Players => players;

        public int Count => players.Count;

        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }

            else if (this.OpenPositions == 0)
            {
                return "There are no more open positions.";
            }

            else if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            else
            {
                players.Add(player);

                return $"Successfully added {player.Name} to the team. Remaining open positions: {--this.OpenPositions}.";
            }
                  
        }

        public bool RemovePlayer(string name)
        {
            var crrPlayer = players.FirstOrDefault(x => x.Name == name);

            if (crrPlayer != null)
            {
                players.Remove(crrPlayer);
                OpenPositions++;
                return true;
            }

            return false;
        }

        public int RemovePlayerByPosition(string position)
        {
            var playersToRemoveCount = players.Count(x => x.Position == position);

            if (playersToRemoveCount > 0)
            {
                var playersToRemove = players.RemoveAll(x => x.Position == position);
                OpenPositions += playersToRemoveCount;
                return playersToRemoveCount;
            }
            
            return 0;
        }

        public Player RetirePlayer(string name)
        {
            var targetPlayer = this.Players.FirstOrDefault(x => x.Name == name);
            if (targetPlayer == null)
            {
                return null;
            }
            targetPlayer.Retired = true;
            return targetPlayer;
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> awardedPlayers = new List<Player>();

            foreach (var player in this.Players.Where(x => x.Games >= games))
            {
                awardedPlayers.Add(player);
            }
            return awardedPlayers;
        }

        public string Report()
        {
            var teams = players.Where(x => x.Retired == false);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");

            foreach (var player in teams)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
