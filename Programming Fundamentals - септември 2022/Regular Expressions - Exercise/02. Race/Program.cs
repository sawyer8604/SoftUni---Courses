using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();


            Dictionary<string, int> race = new Dictionary<string, int>();

            int distance = 0;
            string input;


            while ((input = Console.ReadLine()) != "end of race")
            {
                char[] letters = input.ToCharArray();

                StringBuilder sb = new StringBuilder();

                string crrName;
                distance = 0;

                foreach (var letter in letters)
                {
                    if (char.IsLetter(letter))
                    {
                        sb.Append(letter);

                    }

                    if(char.IsDigit(letter))
                    {
                        distance += letter - 48;
                    }
                }
                crrName = sb.ToString();

                if(names.Contains(crrName))
                {
                    if(!race.ContainsKey(crrName))
                    {
                        race[crrName] = distance;
                    }
                    else
                    {
                        race[crrName] += distance;
                    }
                }
               
            }
            race.OrderByDescending(r => r.Value).Take(3);


            var result = race.OrderByDescending(x => x.Value).Take(3);

            int count = 1;

            foreach (var item in result)
            {
                string place = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count}{place} place: {item.Key}");
                count++;
            }

        }
    }
}
