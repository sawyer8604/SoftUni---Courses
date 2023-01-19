using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int numberOfLinse = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLinse; i++)
            {
                string[] nameAndAge = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            List<Person> result = people.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
