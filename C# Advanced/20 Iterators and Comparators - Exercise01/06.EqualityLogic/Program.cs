using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
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
                string tow = cmdArguments[2];

                Person person = new Person(name, age, tow);

                people.Add(person);
            }

            int indexToCheck = int.Parse(Console.ReadLine());

            Person personToCompare = people[indexToCheck - 1];

            int equalCount = 0;
            int diffCount = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) != 0)
                {
                    diffCount++;
                }
                else
                {
                    equalCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
                return;
            }
            Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
        }
    }
}
