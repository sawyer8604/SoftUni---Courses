﻿using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        private int sum = 0;
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;            
            Group = group;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }        
        public string Group { get; private set; }
        public int Sum => sum;
        public int BuyFood(int number)
        {
            return number;
        }
    }
}
