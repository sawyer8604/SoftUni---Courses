using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Animals
{
    public class Tiger : Feline
    {
        private const double Modifier = 1.00;
        public Tiger(string type, string name, double weight, string livingRegion, string breed)
            : base(type, name, weight, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
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
            return $"{this.Type} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
