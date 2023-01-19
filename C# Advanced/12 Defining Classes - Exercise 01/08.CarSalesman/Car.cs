﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {
        public Car()
        {
           
        }
        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;           
        }
        public Car(string model, Engine engine, int? weight)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
        }

        public Car(string model, Engine engine,  string color)
        {
            Model = model;
            Engine = engine;           
            Color = color;
        }
        public Car(string model, Engine engine, int? weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }
    }
}
