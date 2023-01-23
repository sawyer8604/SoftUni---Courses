using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Generic_Box_of_String
{
    public class Box<T>    {
        
        public Box()
        {
            Items = new List<T>();
        }
        public List<T> Items { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder= new StringBuilder();

            foreach (T item in Items)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item} ");
            }
            
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
