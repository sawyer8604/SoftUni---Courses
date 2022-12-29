using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> list = new Stack<T>();
        public int Count { get { return this.list.Count; } }
        public void Add(T element)
        {
            list.Push(element);
        }

        public T Remove()
        {
            return list.Pop();
        }
    }
}
