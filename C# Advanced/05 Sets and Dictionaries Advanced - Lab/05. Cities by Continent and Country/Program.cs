using System;
using System.Collections.Generic;

namespace _05._Cities_by_Continent_and_Country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> counyties = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split(" ");

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if(!counyties.ContainsKey(continent))
                {
                    counyties[continent] = new Dictionary<string, List<string>>();
                }

                if (!counyties[continent].ContainsKey(country))
                {
                    counyties[continent][country] = new List<string>();
                }

                counyties[continent][country].Add(city);

            }


            foreach (var continent in counyties)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }

            }
        }
    }
}
