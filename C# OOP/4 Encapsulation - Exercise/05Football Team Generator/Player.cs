using System;
using System.Collections.Generic;
using System.Text;

namespace _05Football_Team_Generator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public string Name 
        {
            get
            {
                return name;
            }
            private set 
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.nameShouldNotBeEmpty));
                }
                name = value;
            }
        }        
        public int Endurance 
        {
            get
            {
                return endurance;
            }
            private set
            {
                if(IsOutOfRange(value))
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.StatsShouldBeInTheRange, nameof(this.Endurance)));
                }
                endurance = value;
            }
        }
        public int Sprint 
        {
            get
            {
                return sprint;
            }
            private set
            {
                if (IsOutOfRange(value))
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.StatsShouldBeInTheRange, nameof(this.Sprint)));
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get
            {
                return dribble;
            }
            private set
            {
                if (IsOutOfRange(value))
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.StatsShouldBeInTheRange, nameof(this.Dribble)));
                }
                dribble = value;
            }
        }
        public int Passing
        {
            get
            {
                return passing;
            }
            private set
            {
                if (IsOutOfRange(value))
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.StatsShouldBeInTheRange, nameof(this.Passing)));
                }
                passing = value;
            }
        }
        public int Shooting
        {
            get
            {
                return shooting;
            }
            private set
            {
                if (IsOutOfRange(value))
                {
                    throw new ArgumentException(string.Format(ExeptionMessages.StatsShouldBeInTheRange, nameof(this.Shooting)));
                }
                shooting = value;
            }
        }
        public double SkillLevel => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;

        private bool IsOutOfRange(int element)
        {
            if(element < 0 || element > 100)
            {
                return true;
            }
            return false;
        }
    }
}
