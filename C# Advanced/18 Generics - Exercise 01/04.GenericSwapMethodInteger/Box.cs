using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
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
            T currentElement = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = currentElement;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in Items)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {item}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
