using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Stack
{
    public class MyStack<T> : IEnumerable<T>
    {
        List<T> list;
        int index = 0;

        public MyStack()
        {
            this.list = new List<T>();
        }

        public void Push(T[] element)
        {            

            for (int i = 0; i < element.Length; i++)
            {
                list.Add( element[i]);
            }
        }

        public void Pop()
        {
            if(!list.Any())
            {
                throw new Exception("No elements");
            }

            list.RemoveAt(list.Count - 1);
            index--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
