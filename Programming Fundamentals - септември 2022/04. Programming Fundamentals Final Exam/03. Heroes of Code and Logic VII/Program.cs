using System;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            //"{hero name} {HP} {MP}"

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] names = Console.ReadLine().Split(" ");

                string heroName = names[0];
                int hitPoints = int.Parse(names[1]);
                int manaPoints = int.Parse(names[2]);

                if (!heroes.ContainsKey(heroName))
                {
                    heroes[heroName] = new List<int> { 0, 0 };
                }

                heroes[heroName][0] = hitPoints;
                heroes[heroName][1] = manaPoints;

                if (heroes[heroName][0] > 100)
                {
                    heroes[heroName][0] = 100;
                }

                if (heroes[heroName][1] > 200)
                {
                    heroes[heroName][1] = 200;
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
                            if (heroes[heroName][1] >= neededManaPoint)
                            {
                                heroes[heroName][1] -= neededManaPoint;

                                Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
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
                            heroes[damageHeroName][0] -= damage;

                            if (heroes[damageHeroName][0] > 0)
                            {
                                Console.WriteLine($"{damageHeroName} was hit for {damage} HP by {attacker} and now has {heroes[damageHeroName][0]} HP left!");
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


                            if (heroes[heroRechargeName][1] + amount <= 200)
                            {
                                heroes[heroRechargeName][1] += amount;
                                Console.WriteLine($"{heroRechargeName} recharged for {amount} MP!");
                            }
                            else
                            {
                                int crrMp = 200 - heroes[heroRechargeName][1];

                                heroes[heroRechargeName][1] = 200;

                                Console.WriteLine($"{heroRechargeName} recharged for {crrMp} MP!");
                            }
                        }

                        break;

                    case "Heal":

                        string heroHealName = cmdArguments[1];
                        int healthAmount = int.Parse(cmdArguments[2]);

                        if (heroes[heroHealName][0] + healthAmount <= 100)
                        {
                            heroes[heroHealName][0] += healthAmount;
                            Console.WriteLine($"{heroHealName} healed for {healthAmount} HP!");
                        }
                        else
                        {
                            int crrHp = 100 - heroes[heroHealName][0];

                            heroes[heroHealName][0] = 100;

                            Console.WriteLine($"{heroHealName} healed for {crrHp} HP!");
                        }


                        break;

                }
            }

            foreach (var hero in heroes)
            {
                Console.WriteLine($"{hero.Key}");
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
