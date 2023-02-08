using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ShoppingSpree
{
    public class Person
    {
        private string name;
        private double money;
        private Dictionary<string, List<Product>> bagOfProducts;

        public Person()
        {
            
        }
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            this.bagOfProducts = new Dictionary<string, List<Product>>();
        }
        public IReadOnlyDictionary<string, List<Product>> BagOfProducts => this.bagOfProducts;
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
        public double Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception(ExeptionMessages.moneycannotBeNegative);
                }
                this.money = value;
            }
        }       

        public void AddProduct(Product product)
        { 
            if(this.Money >= product.Cost)
            {
                this.Money -= product.Cost;

                if(!bagOfProducts.ContainsKey(this.Name))
                {
                    bagOfProducts[this.Name] = new List<Product>();
                }

                bagOfProducts[this.Name].Add(product);
                
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if(bagOfProducts.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            foreach (var (name, product) in bagOfProducts)
            {
                sb.Append($"{name} - ");

                List<string> crrProduct = new List<string>();

                foreach (var pr in product)
                {
                    crrProduct.Add(pr.Name);
                }
                sb.AppendLine(string.Join(", ", crrProduct));
            }

            return sb.ToString().TrimEnd();
        }
    }
}
