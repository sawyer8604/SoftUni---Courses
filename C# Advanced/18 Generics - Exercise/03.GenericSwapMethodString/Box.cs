using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Box<T>
    {
        public Box()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            T tempElement = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = tempElement;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 

            foreach (T item in Items) 
            {
                sb.AppendLine($"{typeof(T)}: {item}");
            }
            
            return sb.ToString().TrimEnd();
        }

    }
}
