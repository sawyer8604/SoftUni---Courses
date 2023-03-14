﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool IsValid(object obj);
    }

    public class MyRangeAttribute : MyValidationAttribute
    {
        private readonly int min;
        private readonly int max;

        public MyRangeAttribute(int min, int max)
        {
            this.min = min;
            this.max = max;
        }
        public override bool IsValid(object obj)
        {
            int crrValue = (int)obj;

            return (crrValue >= min && crrValue <= max);
            
        }
    }
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        => obj != null;
    }
}
