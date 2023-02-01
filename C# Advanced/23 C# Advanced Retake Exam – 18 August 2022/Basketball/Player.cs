using System;
using System.Text;
using System.Xml.Linq;

namespace Basketball
{
    public class Player
    {
       
        public Player(string name, string position, double rating, int games)
        {
            Name = name;
            Position = position;
            Rating = rating;
            Games = games;
            this.Retired = false;
        }


        //            •	Name: string
        //•	Position: string
        //•	Rating: double
        //•	Games: int
        //•	Retired: boolean – false by default

        public string Name { get; set; }
        public string Position { get; set; }
        public double Rating { get; set; }
        public int Games { get; set; }
        public bool Retired { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"-Player: {this.Name}");
            sb.AppendLine($"--Position: {this.Position}");
            sb.AppendLine($"--Rating: {this.Rating}");
            sb.AppendLine($"--Games played: {this.Games}");

            return sb.ToString().TrimEnd();
        }
    }
}
