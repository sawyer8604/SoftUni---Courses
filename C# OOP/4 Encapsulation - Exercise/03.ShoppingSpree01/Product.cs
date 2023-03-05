using System;

namespace _03.ShoppingSpree
{
    public class Product
    {
        private string name;
        private double cost;
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception(ExeptionMessages.nameCannotBeEmpty);
                }
                this.name = value;
            }
        }
        public double Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception(ExeptionMessages.moneycannotBeNegative);
                }
                this.cost = value;
            }
        }
    }
}