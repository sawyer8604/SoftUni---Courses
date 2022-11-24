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
            int numberOfLines = int.Parse(Console.ReadLine());

            string patern = @"\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?:(?<population>[0-9]+)[^\@\-\!\:\>]*?\!(?<type>[A|D]{1})\![^\@\-\!\:\>]*?\->(?<count>[0-9]+)";

            List<string> attachkedPlanet = new List<string>();

            List<string> destroyedPlanet = new List<string>();


            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                string encripted = input.ToLower();

                //finding count for decription

                int counter = 0;
                foreach (char letter in encripted)
                {
                    if(letter == 's' || letter == 't' || letter == 'a' || letter == 'r')
                    {
                        counter++;
                    }

                }

                //decriptions 

                StringBuilder decripted = new StringBuilder();

                foreach (char letter in input)
                {
                    decripted.Append((char)(letter - counter));
                }

                string decriptedString = decripted.ToString();

                //create Regex and chek if match or not

                Regex regex = new Regex(patern);

                Match match = regex.Match(decriptedString);

                //if have match add to List - depending of attach type(need two List)

                if(match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    string attackType = match.Groups["type"].Value;

                    if(attackType == "A")
                    {
                        attachkedPlanet.Add(planet);
                    }
                    else
                    {
                        destroyedPlanet.Add(planet);
                    }
                }

            }

            Console.WriteLine($"Attacked planets: {attachkedPlanet.Count}");

            foreach (string planet in attachkedPlanet.OrderBy(planet => planet))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanet.Count}");

            foreach (string planet in destroyedPlanet.OrderBy(planet => planet))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
