﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage.IO.Interfaces
{
    public interface IWriter
    {
        void Write(string text);
        void WriteLine(int text);

    }
}
