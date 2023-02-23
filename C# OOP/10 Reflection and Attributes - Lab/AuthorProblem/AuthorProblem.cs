﻿using System;

namespace AuthorProblem
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; private set; }

        public AuthorAttribute(string name)
        {
            this.Name = name;
        }
    }
}