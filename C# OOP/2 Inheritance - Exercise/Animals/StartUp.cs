using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string command;

            while ((command = Console.ReadLine()) != "Beast!")
            {


                string[] animal = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = animal[0];
                int age = int.Parse(animal[1]);

                if (age < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                Animal crrAnimal = default;

                switch (command)
                {
                    case "Dog":

                        crrAnimal = new Dog(name, age, animal[2]);

                        break;

                    case "Cat":

                        crrAnimal = new Cat(name, age, animal[2]);

                        break;

                    case "Frog":

                        crrAnimal = new Frog(name, age, animal[2]);

                        break;

                    case "Kitten":

                        crrAnimal = new Kitten(name, age);

                        break;

                    case "Tomcat":
                        crrAnimal = new Tomcat(name, age);

                        break;

                }

                Console.WriteLine(command);
                Console.WriteLine($"{crrAnimal.Name} {crrAnimal.Age} {crrAnimal.Gender}");

                Console.WriteLine($"{crrAnimal.ProduceSound()}");
            }

        }
        
    }
}
