
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        List<T> elements = new List<T>();

        public int Count
        {
            get
            {
                return elements.Count;
            }
        }

        public void Add(T element)
        {
            elements.Add(element);
        }

        public T Remove()
        {
            T element = elements[elements.Count - 1];

            elements.RemoveAt(elements.Count - 1);

            return element;
        }
    }
}
