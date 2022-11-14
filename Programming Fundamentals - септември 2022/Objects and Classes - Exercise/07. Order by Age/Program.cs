using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Persons> persons = new List<Persons>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" ");

                string name = arguments[0];
                string id = arguments[1];
                int age = int.Parse(arguments[2]);

                Persons person = new Persons(name, id, age);
                
                bool isPersonExist = persons.Any(p => p.Id == id);
                if (isPersonExist)
                {
                    person.Name = name;
                    person.Age = age;
                }
                else
                {
                    persons.Add(person);
                }
                
            }

            foreach (Persons person in persons.OrderBy(a => a.Age))
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Persons
    {
        public Persons(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }        
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{this.Name} with ID: {this.Id} is {this.Age} years old.";
        }
    }
}
