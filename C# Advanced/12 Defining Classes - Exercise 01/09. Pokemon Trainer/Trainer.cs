using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Pokemon_Trainer
{
    public class Trainer
    {
        public Trainer()
        {

        }
        public Trainer(string name, int numberOfBadges)
        {
            Name = name;
            NumberOfBadges = numberOfBadges;
            ListOfPokemons = new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> ListOfPokemons { get; set; }
    }
}
