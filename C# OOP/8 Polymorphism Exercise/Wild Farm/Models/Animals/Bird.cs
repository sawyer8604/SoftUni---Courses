using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Animals
{
    public abstract class Bird : Animal
    {
        protected Bird(string type, string name, double weight, double wingSize)
            : base(type, name, weight)
        {
            this.WingSize = wingSize;
        }

        public double WingSize { get; set; }

    }
}
