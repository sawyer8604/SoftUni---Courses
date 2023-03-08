using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        protected Animal(string type, string name, double weight)
        {
            Type = type;
            Name = name;
            Weight = weight;            
        }

        public string Type { get; protected set; }
        public string Name { get; protected set; }
        public double Weight { get; protected set; }
        public int FoodEaten { get; protected set; }
        public bool IsEat { get; set; }


        public abstract string ProduceSound();

        public abstract void Eat(IFood food);
       

    }
}
