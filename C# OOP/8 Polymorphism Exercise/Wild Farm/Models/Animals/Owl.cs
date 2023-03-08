using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Animals
{
    public class Owl : Bird
    {
        private const double Modifier = 0.25;
        public Owl(string type, string name, double weight, double wingSize)
            : base(type, name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }

        public override void Eat(IFood food)
        {
            if (food.Type == "Meat")
            {
                this.Weight += food.Quantity * Modifier;
                this.FoodEaten += food.Quantity;
                this.IsEat = true;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"{this.Type} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
