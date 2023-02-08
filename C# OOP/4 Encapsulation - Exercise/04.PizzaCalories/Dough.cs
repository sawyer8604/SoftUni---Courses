using System;
using System.Collections.Generic;
using System.Text;

namespace _04.PizzaCalories
{
    public class Dough
    {
        private string type;
        private string technique;
        private double grams;

        private readonly Dictionary<string, double> doughs = new Dictionary<string, double>()
        {
             {"white", 1.5 },
             {"wholegrain" , 1.0},
             {"crispy" , 0.9},
             {"chewy" , 1.1},
             {"homemade" , 1.0}
        };

        public Dough(string type, string technique, double grams)
        {
            Type = type;
            Technique = technique;
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
                Validation(value.ToLower());

                type = value;
            }
        }
        public string Technique
        {
            get
            {
                return technique;
            }
            private set
            {
                Validation(value.ToLower());

                technique = value;
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
                if (value < 0 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                grams = value;
            }
        }
        public double Calories => (2 * Grams) * doughs[Type.ToLower()] * doughs[Technique.ToLower()];

        private bool Validation(string type)
        {
            if (!doughs.ContainsKey(type.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");

            }
            return true;
        }

    }
}
