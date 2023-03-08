using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Models.Animals
{
    public abstract class Feline : Mammal
    {

        protected Feline(string type, string name, double weight, string livingRegion, string breed)
            : base(type, name, weight, livingRegion)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }
    }
}
