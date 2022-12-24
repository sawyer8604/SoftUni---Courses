using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Pter";
            person.Age = 20;

            Person person1 = new Person();
            person1.Name = "George";
            person1.Age = 18;

            Person person2 = new Person();
            person2.Name = "Jose";
            person2.Age = 43;

            Console.WriteLine($"{person.Name} {person.Age}");
            Console.WriteLine($"{person1.Name} {person1.Age}");
            Console.WriteLine($"{person2.Name} {person2.Age}");

        }
    }
}
