using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Animals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string type, string name, double weight, string livingRegion)
            : base(type, name, weight)
        {
            this.LivingRegion = livingRegion;
        }
        public string LivingRegion { get; set; }
    }
}
