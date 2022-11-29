using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII___With_Class
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Hero> heroesList = new List<Hero>();

            InitializeHeroes(heroesList);
            PlayWithHeroes(heroesList);

            foreach (Hero hero in heroesList)
            {
                Console.WriteLine(hero.ToString());
            }
        }

        static void CastSpellHero(Hero hero, int mpNeeded, string spellName)
        {
            if (hero.ManaPoints >= mpNeeded)
            {
                hero.ManaPoints -= mpNeeded;
                Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
            }
            else
            {
                Console.WriteLine($"{hero.Name} does not have enough MP to cast {spellName}!");
            }
        }

        static void TakeDamageHero(Hero hero, int damage, string attacker, List<Hero> heroesList)
        {
            hero.HitPoints -= damage;
            if (hero.HitPoints > 0)
            {
                Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HitPoints} HP left!");
            }
            else
            {
                heroesList.Remove(hero);
                Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
            }
        }
        static void PlayWithHeroes(List<Hero> heroesList)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArg = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArg[0];
                string heroName = cmdArg[1];
                Hero hero = heroesList.FirstOrDefault(x => x.Name == heroName);

                if (command == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArg[2]);
                    string spellName = cmdArg[3];
                    CastSpellHero(hero, mpNeeded, spellName);

                }
                else if (command == "TakeDamage")
                {
                    int damage = int.Parse(cmdArg[2]);
                    string attacker = cmdArg[3];
                    TakeDamageHero(hero, damage, attacker, heroesList);
                }
                else if (command == "Recharge")
                {
                    int ammount = int.Parse(cmdArg[2]);
                    hero.Recharge(ammount);
                }
                else if (command == "Heal")
                {
                    int ammount = int.Parse(cmdArg[2]);
                    hero.Heal(ammount);
                }
            }
        }
        static void InitializeHeroes(List<Hero> heroesList)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] heroInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string heroName = heroInfo[0];
                int hitPoints = int.Parse(heroInfo[1]) > 100 ? 100 : int.Parse(heroInfo[1]);
                int manaPoints = int.Parse(heroInfo[2]) > 200 ? 200 : int.Parse(heroInfo[2]);

                Hero newHero = new Hero(heroName, hitPoints, manaPoints);
                heroesList.Add(newHero);
            }
        }
    }

    public class Hero
    {
        public Hero(string name, int hitPoints, int manaPoints)
        {
            Name = name;
            HitPoints = hitPoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }

        public int HitPoints { get; set; }

        public int ManaPoints { get; set; }

        public void Heal(int ammount)
        {
            if (this.HitPoints + ammount > 100)
            {
                ammount = 100 - this.HitPoints;
            }
            this.HitPoints += ammount;
            Console.WriteLine($"{this.Name} healed for {ammount} HP!");
        }

        public void Recharge(int ammount)
        {
            if (this.ManaPoints + ammount > 200)
            {
                ammount = 200 - this.ManaPoints;
            }
            this.ManaPoints += ammount;
            Console.WriteLine($"{this.Name} recharged for {ammount} MP!");
        }

        public override string ToString()
        {
            return $"{this.Name}\n" +
                $"HP: {this.HitPoints}\n" +
                $"MP: {this.ManaPoints}";
        }
    }
}