using System;
using System.Collections.Generic;

namespace _05.Comparing_Objects
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = cmdArguments[0];
                int age = int.Parse(cmdArguments[1]);
                string town = cmdArguments[2];

                Person person = new Person(name, age, town);

                people.Add(person);
                
            }

            int compareIndex = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[compareIndex];

            int equalCount = 0;
            int diffCount = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
            }
        }
    }
}
