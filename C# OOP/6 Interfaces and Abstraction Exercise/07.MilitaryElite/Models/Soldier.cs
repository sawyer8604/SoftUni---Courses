﻿using _07.MilitaryElite.Models.Interfaces;

namespace _07.MilitaryElite.Models
{
    public abstract class Soldier : ISoldier
    {
        protected Soldier(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
