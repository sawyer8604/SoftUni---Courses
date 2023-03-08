using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Interfaces;

namespace Wild_Farm.Models.Foods
{
    public abstract class Food : IFood
    {
        protected Food(string type, int quantity)
        {
            Type = type;
            Quantity = quantity;
        }

        public string Type { get; protected set; }

        public int Quantity { get; protected set; }
    }
}
