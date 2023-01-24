using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        string name;
        int age;
        string town;

        public Person(string name, int age, string town)
        {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other)
        {
            int name = this.name.CompareTo(other.name);
            if(name != 0)
            {
                return name;
            }

            int age = this.age.CompareTo(other.age);
            if(age != 0)
            {
                return age;
            }

            return this.town.CompareTo(other.town);
        }
    }
}
