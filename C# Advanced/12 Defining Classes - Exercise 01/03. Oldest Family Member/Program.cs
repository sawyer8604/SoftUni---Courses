using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family people = new Family();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] nameAndAge = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = nameAndAge[0];
                int age = int.Parse(nameAndAge[1]);

                Person person = new Person(name, age);

                people.AddMember(person);
            }

            Person oldestMember = people.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
