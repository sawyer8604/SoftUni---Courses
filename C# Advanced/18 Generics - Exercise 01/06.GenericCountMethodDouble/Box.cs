using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box<T>
         where T : IComparable<T>
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
        public int CompareElements(T itemToCompare)
        {
            int count = 0;
            foreach (var item in Items)
            {
                if (item.CompareTo(itemToCompare) > 0)
                {
                    count++;
                }
            }
            return count;
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
