using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { ',', ' '};

            string[] namesOfDemons = Console.ReadLine().Split(chars, StringSplitOptions.RemoveEmptyEntries);

            string healthPatern = @"(?<name>[^\*\+\-\/\.\,\ \d])";

            string damagePattern = @"(\-*?\d+(\.\d+)*)";

            double health = 0;

            double damages = 0;

            Regex healthRegex = new Regex(healthPatern);

            Regex damagaRegex = new Regex(damagePattern);

            Dictionary<string, Dictionary<double, double>> monsters = new Dictionary<string, Dictionary<double, double>>();

            for (int i = 0; i < namesOfDemons.Length; i++)
            {
                string names = namesOfDemons[i];

                string crrHealthAsString = "";

                double crrHealth = 0;

                MatchCollection matchsHealth = healthRegex.Matches(names);

                bool IsmatmatchsHealth = healthRegex.IsMatch(names);

                if(IsmatmatchsHealth)
                {
                    foreach (Match match in matchsHealth)
                    {
                        crrHealthAsString += match.Value;
                    }

                }

                foreach (var letter in crrHealthAsString)
                {
                    crrHealth += (int)letter;
                }

                MatchCollection matchDamages = damagaRegex.Matches(names);

                double crrDamage = 0;

                bool IsmatmatchsDamages = damagaRegex.IsMatch(names);

                if(IsmatmatchsDamages)
                {
                    foreach (Match match in matchDamages)
                    {
                        crrDamage += double.Parse(match.Value);
                    }
                }

                int multiplyCounter = 0;
                
                foreach (char letter in names)
                {
                    if(letter == '*')
                    {
                        multiplyCounter++;
                        
                    }
                }

                for (int j = 0; j < multiplyCounter; j++)
                {
                    crrDamage *= 2;
                }

                int dividingCounter = 0;
                
                foreach (char letter in names)
                {
                    if (letter == '/')
                    {
                        dividingCounter++;

                    }
                }

                for (int j = 0; j < dividingCounter; j++)
                {
                    crrDamage /= 2;
                }


                if(!monsters.ContainsKey(names))
                {
                    monsters[names] = new Dictionary<double, double>();

                    if(!monsters[names].ContainsKey(crrHealth))
                    {
                        monsters[names][crrHealth] = crrDamage;
                    }
                }
            }

            foreach (var (name, healths) in monsters.OrderBy(name => name.Key))
            {
                foreach (var (healts, damage) in healths)
                {
                    Console.WriteLine($"{name} - {healts} health, {damage:f2} damage");
                }
            }

        }
    }
}
