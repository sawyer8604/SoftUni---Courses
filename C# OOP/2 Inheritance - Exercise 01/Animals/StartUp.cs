using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            string type;

            while ((type = Console.ReadLine()) != "Beast!")
            {
                try
                {
                    string[] animalInformation = Console.ReadLine().Split(" ");
                    string name = animalInformation[0];
                    int age = int.Parse(animalInformation[1]);

                    Animal animal = default;

                    if (type == "Cat")
                    {
                        animal = new Cat(name, age, animalInformation[2]);
                    }
                    else if (type == "Dog")
                    {
                        animal = new Dog(name, age, animalInformation[2]);
                    }
                    else if (type == "Frog")
                    {
                        animal = new Frog(name, age, animalInformation[2]);
                    }
                    else if (type == "Kitten")
                    {
                        animal = new Kitten(name, age);
                    }
                    else if (type == "Tomcat")
                    {
                        animal = new Tomcat(name, age);
                    }



                    Console.WriteLine($"{type}");

                    Console.WriteLine($"{animal.Name} {animal.Age} {animal.Gender}");


                    Console.WriteLine(animal.ProduceSound());
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
