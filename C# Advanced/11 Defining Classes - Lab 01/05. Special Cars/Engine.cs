﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        int horsePower;
        double cubicCapacity;

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower
        {
            get { return this.horsePower; }
            private set { this.horsePower = value; }
        }

        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            private set { this.cubicCapacity = value; }
        }

    }
}