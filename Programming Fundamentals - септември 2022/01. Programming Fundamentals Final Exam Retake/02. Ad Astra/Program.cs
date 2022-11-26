using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)(?<name>[A-za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d{1,4}|10000)\1";

            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            int numberOfDays = 0;

            MatchCollection matches = regex.Matches(input);


            int totalCalories = matches.Select(x => int.Parse(x.Groups["calories"].ToString())).Sum();

            numberOfDays = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {numberOfDays} days!");

            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                string date = match.Groups["date"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);

                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }


        }
    }
}
