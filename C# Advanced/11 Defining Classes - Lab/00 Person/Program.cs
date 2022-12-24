using System;

namespace _00_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "Pesho";

            string name = person.Name;

            Console.WriteLine(person.Name);

            Console.WriteLine(person.Name);
        }
    }

    class Person
    {
        private string name;

        public string Name
        {
            get
            {
                Console.WriteLine("In getter");
                return this.name;
            }
            set
            {
                Console.WriteLine("In setter");
                this.name = value;
            }
        }
    }
}
