using System;
using System.Collections.Generic;

namespace _06._Equality_Logic
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedSet = new SortedSet<Person>();

            HashSet<Person> hashSet = new HashSet<Person>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = commands[0];
                int age = int.Parse(commands[1]);

                Person peson = new Person(name, age);

                sortedSet.Add(peson);
                hashSet.Add(peson);
            }

            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
}
