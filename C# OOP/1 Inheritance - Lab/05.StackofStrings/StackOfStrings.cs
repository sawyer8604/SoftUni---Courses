﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _05.StackofStrings
{
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return (this.Count == 0);
        }

        public Stack<string> AddRange(IEnumerable<string> elemtns)
        {
            foreach (var item in elemtns)
            {
                this.Push(item);
            }

            return this;
        }
    }
}
