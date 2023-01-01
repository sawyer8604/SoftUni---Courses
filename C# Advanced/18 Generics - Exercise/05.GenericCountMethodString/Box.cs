using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T> where T : IComparable<T>
    {
        public Box()
        {
            Items = new List<T>();
        }

        public List<T> Items { get; set; }

        public int Count(T toComparisont)
        {
            int count = 0;  

            foreach (var item in Items)
            {
                if(item.CompareTo(toComparisont) > 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
