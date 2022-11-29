using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heroes_of_Code_and_Logic_VII_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, Heroes> heroes = new Dictionary<string, Heroes>();

            //"{hero name} {HP} {MP}"

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] names = Console.ReadLine().Split(" ");

                string heroName = names[0];
                int hitPoints = int.Parse(names[1]);
                int manaPoints = int.Parse(names[2]);

                if (!heroes.ContainsKey(heroName))
                {
                    heroes[heroName] = new Heroes(hitPoints, manaPoints);
                }

                

                if (heroes[heroName].HP > 100)
                {
                    heroes[heroName].HP = 100;
                }

                if (heroes[heroName].MP > 200)
                {
                    heroes[heroName].MP = 200;
                }
            }

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] cmdArguments = commands.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {

                    case "CastSpell":
                        string heroName = cmdArguments[1];
                        int neededManaPoint = int.Parse(cmdArguments[2]);
                        string spellName = cmdArguments[3];

                        if (heroes.ContainsKey(heroName))
                        {
                            if (heroes[heroName].MP >= neededManaPoint)
                            {
                                heroes[heroName].MP -= neededManaPoint;

                                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                            }
                            else
                            {
                                Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                            }
                        }

                        break;

                    case "TakeDamage":

                        string damageHeroName = cmdArguments[1];
                        int damage = int.Parse(cmdArguments[2]);
                        string attacker = cmdArguments[3];

                        if (heroes.ContainsKey(damageHeroName))
                        {
                            heroes[damageHeroName].HP -= damage;

                            if (heroes[damageHeroName].HP > 0)
                            {
                                Console.WriteLine($"{damageHeroName} was hit for {damage} HP by {attacker} and now has {heroes[damageHeroName].HP} HP left!");
                            }
                            else
                            {
                                Console.WriteLine($"{damageHeroName} has been killed by {attacker}!");

                                heroes.Remove(damageHeroName);
                            }

                        }

                        break;


                    case "Recharge":

                        string heroRechargeName = cmdArguments[1];
                        int amount = int.Parse(cmdArguments[2]);

                        if (heroes.ContainsKey(heroRechargeName))
                        {


                            if (heroes[heroRechargeName].MP + amount <= 200)
                            {
                                heroes[heroRechargeName].MP += amount;
                                Console.WriteLine($"{heroRechargeName} recharged for {amount} MP!");
                            }
                            else
                            {
                                int crrMp = 200 - heroes[heroRechargeName].MP;

                                heroes[heroRechargeName].MP = 200;

                                Console.WriteLine($"{heroRechargeName} recharged for {crrMp} MP!");
                            }
                        }

                        break;

                    case "Heal":

                        string heroHealName = cmdArguments[1];
                        int healthAmount = int.Parse(cmdArguments[2]);

                        if (heroes[heroHealName].HP + healthAmount <= 100)
                        {
                            heroes[heroHealName].HP += healthAmount;
                            Console.WriteLine($"{heroHealName} healed for {healthAmount} HP!");
                        }
                        else
                        {
                            int crrHp = 100 - heroes[heroHealName].HP;

                            heroes[heroHealName].HP = 100;

                            Console.WriteLine($"{heroHealName} healed for {crrHp} HP!");
                        }


                        break;

                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
            }
        }

        public class Heroes
        {
            public Heroes(int hP, int mP)
            {
               
                HP = hP;
                MP = mP;
            }

            public int HP { get; set; }
            public int MP { get; set; }
        }
    }
}
