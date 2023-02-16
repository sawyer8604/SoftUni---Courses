namespace Raiding.Factory
{
    using Raiding.Models.Interfaces;
    using Raiding.Models;
    using System;

    public class HeroType
    {
        public IBaseHero CreateHero(string type, string name)
        {
            IBaseHero hero;

            if (type == "Druid")
            {
                hero = new Druid(name);
            }
            else if (type == "Paladin")
            {
                hero = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name);
            }
            else if(type == "Warrior")
            {
                hero = new Warrior(name);
            }
             else
            {
                throw new ArgumentException("Invalid hero!");
            }
            return hero;
        }
    }
}
