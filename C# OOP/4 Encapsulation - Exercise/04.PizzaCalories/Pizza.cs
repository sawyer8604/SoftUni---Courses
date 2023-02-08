using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.PizzaCalories
{
    public class Pizza
    {

        private string name;

        private List<Topping> toppings;

        private Dough dough;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Toppings = toppings;
            Doughs = dough;
            toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public List<Topping> Toppings
        {
            get { return toppings; }
            private set
            {
                toppings = value;
            }
        }

        public Dough Doughs
        {
            get { return dough; }
            private set { dough = value; }
        }

        public double Calories => this.Doughs.Calories + Toppings.Sum(x => x.Calories);

        public void AddToppings(Topping toping)
        {
            if (Toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            Toppings.Add(toping);
        }
    }
}
