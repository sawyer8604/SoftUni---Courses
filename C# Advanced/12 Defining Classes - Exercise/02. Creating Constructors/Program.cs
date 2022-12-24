using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();            

            Person person1 = new Person(19);
           
            Person person2 = new Person(36, "Mus");
            
            Console.WriteLine($"{person.Name} {person.Age}");
            Console.WriteLine($"{person1.Name} {person1.Age}");
            Console.WriteLine($"{person2.Name} {person2.Age}");

        }
    }
}
