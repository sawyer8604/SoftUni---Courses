using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            string starPattenr = @"[star]";

            string pattern = @"@(?<name>[A-Za-z]+)[^@\-!,:>]*?:(?<population>[0-9]+)[^@\-!,:>]*?!(?<attackType>[A|D]{1})![^@\-!,:>]*?->(?<soldierCount>[\d]+)";

            List<string> attackedPlanet = new List<string>();
            List<string> destroyedPlanet = new List<string>();


            for (int i = 0; i < numberOfMessages; i++)
            {
                string encrypMessage = Console.ReadLine();

                MatchCollection match = Regex.Matches(encrypMessage, starPattenr, RegexOptions.IgnoreCase);
                int count = match.Count;

                string message = EncriptedMessage(encrypMessage, count);

                Match matches = Regex.Match(message, pattern);
                if (matches.Success)
                {
                    AttackOrDestroyedPlanet(attackedPlanet, destroyedPlanet, matches);

                }
            }
            PrintTheResults(attackedPlanet, destroyedPlanet);
        }

        static void PrintTheResults(List<string> attackedPlanet, List<string> destroyedPlanet)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanet.Count}");

            foreach (var planet in attackedPlanet.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");

            foreach (var planet in destroyedPlanet.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        static void AttackOrDestroyedPlanet(List<string> attackedPlanet, List<string> destroyedPlanet, Match matches)
        {
            string planetName = matches.Groups["name"].Value;

            string attachType = matches.Groups["attackType"].Value;


            if (attachType == "A")
            {
                attackedPlanet.Add(planetName);
            }
            else if (attachType == "D")
            {
                destroyedPlanet.Add(planetName);
            }
        }

        static string EncriptedMessage(string encrypMessage, int count)
        {
            StringBuilder decriptedMessage = new StringBuilder();

            foreach (char letter in encrypMessage)
            {
                char decriptMssg = (char)(letter - count);
                decriptedMessage.Append(decriptMssg);
            }

            string message = decriptedMessage.ToString();
            return message;
        }
    }
}
