using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mus", 36);

            Console.WriteLine($"{person.Name} {person.Age}");
        }
    }
}
