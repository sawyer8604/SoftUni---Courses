using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Topping
    {

        private readonly Dictionary<string, double> types = new Dictionary<string, double>()
        {
             {"meat", 1.2 },
             {"veggies" , 0.8},
             {"cheese" , 1.1},
             {"sauce" , 0.9}
        };

        private string type;

        private double grams;

        private readonly string outsideType;
        public Topping(string type, double grams)
        {
            outsideType = type;
            Type = type;
            Grams = grams;
            
        }


        public string Type
        {
            get
            {
                return type;
            }
            private set
            {
                if (!types.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {outsideType} on top of your pizza.");

                }

                type = value;
            }
        }
        public double Grams
        {
            get
            {
                return grams;
            }
            private set
            {
                if (value < 0 || value > 50)
                {
                    throw new ArgumentException($"{Type} weight should be in the range [1..50].");
                }

                grams = value;
            }
        }

        public double Calories => 2 * Grams * types[type.ToLower()];

    }
}
