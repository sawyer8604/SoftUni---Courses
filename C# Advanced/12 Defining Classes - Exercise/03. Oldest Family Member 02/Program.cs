using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] args = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                int age = int.Parse(args[1]);
                family.AddMember(new Person(name, age));
            }

            family.GetOldestMember();
        }
    }

    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }

    public class Family
    {
        private List<Person> people;

        public Family()
        {
            people = new List<Person>();
        }

        public List<Person> People { get { return people; } set { people = value; } }

        public void AddMember(Person person)
        {
            this.People.Add(person);
        }

        public void GetOldestMember()
        {
            Console.WriteLine(People.OrderByDescending(x => x.Age).First());
        }
    }
}