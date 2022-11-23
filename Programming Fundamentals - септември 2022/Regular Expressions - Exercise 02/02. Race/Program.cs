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

            List<string> practicipans = Console.ReadLine().Split(", ").ToList();

            string input;

            Dictionary<string, int> people = new Dictionary<string, int>();


            while ((input = Console.ReadLine()) != "end of race")
            {
                string name = string.Empty;

                int sum = 0;

                foreach (char ch in input)
                {
                    if (char.IsDigit(ch))
                    {

                        sum += ch - 48;
                    }
                }
                StringBuilder sb = new StringBuilder();

                foreach (char ch in input)
                {
                    if (char.IsLetter(ch))
                    {

                        sb.Append(ch);
                    }
                }

                name = sb.ToString();

                if (practicipans.Contains(name))
                {
                    if (!people.ContainsKey(name))
                    {
                        people[name] = 0;
                    }
                    people[name] += sum;

                }


            }

            int counter = 0;


            //var ordered = people.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            // ordered in new Dictionary


            foreach (var person in people.OrderByDescending(km => km.Value))
            {
                counter++;
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {person.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {person.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {person.Key}");
                    break;
                }

            }
        }
    }
}
