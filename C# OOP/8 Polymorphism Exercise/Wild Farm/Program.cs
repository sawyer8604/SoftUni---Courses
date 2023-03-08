using System;
using System.Collections.Generic;
using Wild_Farm.Models.Animals;
using Wild_Farm.Models.Foods;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;

            List<IAnimal> animals = new List<IAnimal>();

            while ((input = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] animalInfo = input.Split();

                    string[] foodInfo = Console.ReadLine().Split();

                    string animalType = animalInfo[0];
                    string animalName = animalInfo[1];
                    double animalWeight = double.Parse(animalInfo[2]);


                    IAnimal animal = null;

                    if (animalType == "Hen")
                    {

                        double wingSize = double.Parse(animalInfo[3]);

                        animal = new Hen(animalType, animalName, animalWeight, wingSize);

                    }
                    else if (animalType == "Owl")
                    {

                        double wingSize = double.Parse(animalInfo[3]);

                        animal = new Owl(animalType, animalName, animalWeight, wingSize);
                    }
                    else if (animalType == "Mouse")
                    {

                        string livingRegion = animalInfo[3];

                        animal = new Mouse(animalType, animalName, animalWeight, livingRegion);

                    }
                    else if (animalType == "Cat")
                    {
                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];

                        animal = new Cat(animalType, animalName, animalWeight, livingRegion, breed);
                    }
                    else if (animalType == "Dog")
                    {

                        string livingRegion = animalInfo[3];

                        animal = new Dog(animalType, animalName, animalWeight, livingRegion);

                    }
                    else if (animalType == "Tiger")
                    {

                        string livingRegion = animalInfo[3];
                        string breed = animalInfo[4];

                        animal = new Tiger(animalType, animalName, animalWeight, livingRegion, breed);
                    }

                    Console.WriteLine(animal.ProduceSound()); 

                    string foodType = foodInfo[0];
                    int foodQuantity = int.Parse(foodInfo[1]);

                    IFood food = null;

                    if (foodType == "Vegetable")
                    {
                        food = new Vegetable(foodType, foodQuantity);
                    }
                    else if (foodType == "Fruit")
                    {
                        food = new Fruit(foodType, foodQuantity);
                    }
                    else if (foodType == "Meat")
                    {
                        food = new Meat(foodType, foodQuantity);
                    }
                    else if (foodType == "Seeds")
                    {
                        food = new Seeds(foodType, foodQuantity);
                    }

                    animals.Add(animal);

                    animal.Eat(food);

                    if (animal.IsEat == true)
                    {
                        animals.RemoveAt(animals.Count - 1);
                        animals.Add(animal);
                    }

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }

        }
    }
}
