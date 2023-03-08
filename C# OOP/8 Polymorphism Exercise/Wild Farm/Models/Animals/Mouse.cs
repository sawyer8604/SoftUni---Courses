﻿using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Animals
{
    public class Mouse : Mammal
    {
        private const double Modifier = 0.1;
        public Mouse(string type, string name, double weight, string livingRegion)
            : base(type, name, weight, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override void Eat(IFood food)
        {
            if (food.Type == "Vegetable" || food.Type == "Fruit")
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
            return $"{this.Type} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
