using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        private int age;
        public Child(string name, int age)
            : base(name, age)
        {


        }

        public override int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value > 15)
                {
                    throw new Exception("Age can't be bigger than 15");
                }
                this.age = value;
            }
        }
    }
}
