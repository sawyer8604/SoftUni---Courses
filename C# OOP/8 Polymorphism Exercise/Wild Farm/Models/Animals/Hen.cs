using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Animals
{
    public class Hen : Bird
    {
        private const double Modifier = 0.35;
        public Hen(string type, string name, double weight, double wingSize)
            : base(type, name, weight, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
        public override void Eat(IFood food)
        {
            this.Weight += food.Quantity * Modifier;
            this.FoodEaten += food.Quantity;
            this.IsEat = true;
        }

        public override string ToString()
        {
            return $"{this.Type} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

    }
}
