using System;
using System.Text.RegularExpressions;

namespace _02The_Isle_of_Man_TT_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"(?<d>[\#\$\%\*\&])(?<name>[A-Za-z]+)(\k<d>)=(?<number>[0-9]+)!!(?<code>.+)";

            int numberOflines = int.Parse(Console.ReadLine());

            Regex regex = new Regex(patern);

            for (int i = 0; i < numberOflines; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups["name"].Value;

                    int number = int.Parse(match.Groups["number"].Value);

                    string code = match.Groups["code"].Value;

                    string crrCode = "";

                    if (number == code.Length)
                    {
                        for (int j = 0; j < code.Length; j++)
                        {
                            char crrChar = code[j];

                            crrCode += (char)(crrChar + number);
                        }
                        Console.WriteLine($"Coordinates found! {name} -> {crrCode}");
                    }
                    else
                    {
                        Console.WriteLine("Nothing found!");
                    }


                }
                else
                {
                    Console.WriteLine("Nothing found!");
                }
            }
        }
    }
}
