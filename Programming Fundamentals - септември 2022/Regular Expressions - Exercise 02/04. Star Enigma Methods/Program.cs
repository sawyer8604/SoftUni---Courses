using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma_Methods
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

                int counter = FindCountForDecription(encripted);

                //decriptions 

                StringBuilder decripted = new StringBuilder();

                string decriptedString = Decription(input, counter, decripted);

                //create Regex and chek if match or not

                Regex regex = new Regex(patern);

                Match match = regex.Match(decriptedString);

                //if have match add to List - depending of attach type(need two Lists)

                MatchSucces(attachkedPlanet, destroyedPlanet, match);

            }
            //print the result

            PrintTheResult(attachkedPlanet, destroyedPlanet);
        }

        
        static int FindCountForDecription(string encripted)
        {
            int counter = 0;
            foreach (char letter in encripted)
            {
                if (letter == 's' || letter == 't' || letter == 'a' || letter == 'r')
                {
                    counter++;
                }

            }

            return counter;
        }

        static string Decription(string input, int counter, StringBuilder decripted)
        {
            foreach (char letter in input)
            {
                decripted.Append((char)(letter - counter));
            }

            string decriptedString = decripted.ToString();
            return decriptedString;
        }
        static void MatchSucces(List<string> attachkedPlanet, List<string> destroyedPlanet, Match match)
        {
            if (match.Success)
            {
                string planet = match.Groups["planet"].Value;
                string attackType = match.Groups["type"].Value;

                if (attackType == "A")
                {
                    attachkedPlanet.Add(planet);
                }
                else
                {
                    destroyedPlanet.Add(planet);
                }
            }
        }

        static void PrintTheResult(List<string> attachkedPlanet, List<string> destroyedPlanet)
        {
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
