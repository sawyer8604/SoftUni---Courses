using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;
        public Zoo(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            this.animals = new List<Animal>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public IReadOnlyCollection<Animal> Animals => animals;

        public string AddAnimal(Animal animal)
        {
            if(string.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            else if(animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            else if(animals.Count >= this.Capacity)
            {
                return "The zoo is full.";
            }
            else
            {
                animals.Add(animal);
                return $"Successfully added {animal.Species} to the zoo.";
            }
        }

        public int RemoveAnimals(string species)
        {
            var animalsForRemove = animals.Where(x => x.Species == species);
            int count = 0;
            if(animalsForRemove.Any())
            {
                foreach (var item in animalsForRemove)
                {
                    count++;
                }
                return count;
            }
            return 0;

        }
        public List<Animal> GetAnimalsByDiet(string diet)
        {
             var animalsDiet = animals.Where(x => x.Diet == diet).ToList(); // chechk
            if(animalsDiet.Any())
            {
                return animalsDiet;
            }
            return null;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            return animals.FirstOrDefault(x => x.Weight == weight);
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;
            foreach (var animal in animals)
            {
                if(animal.Length >= minimumLength && animal.Length <= maximumLength)
                {
                    count++;
                }
            }

            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
