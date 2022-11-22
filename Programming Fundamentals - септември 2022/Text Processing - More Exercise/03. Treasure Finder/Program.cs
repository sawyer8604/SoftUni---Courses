using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input;

            string newMessage = string.Empty;

            string typePattenr = @"&(?<type>[A-Za-z]+)&";

            string coordinatePattern = @"<(?<coordinate>[\w]+)>";

            while ((input = Console.ReadLine()) != "find")
            {
                char[] inputAsChar = input.ToCharArray();

                int numberCounter = 0;

                for (int i = 0; i < inputAsChar.Length; i++)
                {
                    
                    if (numberCounter >= number.Length)
                    {
                        numberCounter = 0;
                    }

                    int currSymbol = (int)(inputAsChar[i]) - number[numberCounter];
                    char currChar = (char)currSymbol;
                    inputAsChar[i] = currChar;

                    numberCounter++;                    

                }
                newMessage = new string(inputAsChar);

                MatchCollection matches = Regex.Matches(newMessage, typePattenr);
                MatchCollection matches2 = Regex.Matches(newMessage, coordinatePattern);

                foreach (Match match in matches)
                {
                    foreach (Match match2 in matches2)
                    {
                        Console.WriteLine($"Found {match.Groups["type"]} at {match2.Groups["coordinate"]}");
                    }
                   
                }
               

            }
        }
    }
}
