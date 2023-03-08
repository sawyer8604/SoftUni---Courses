using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Interfaces
{
    public interface IAnimal
    {
        public string Type { get;}
        public string Name { get; }
        public double Weight { get;  }
        public int FoodEaten { get; }
        public bool IsEat { get; set; }

        public string ProduceSound();
        public void Eat(IFood food);
    }
}
