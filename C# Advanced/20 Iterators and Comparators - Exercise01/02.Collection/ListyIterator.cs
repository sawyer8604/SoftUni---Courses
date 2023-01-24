using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        List<T> list;
        int currentIndex = 0;
        public ListyIterator(List<T> list)
        {
            this.list = list;
        }

        public bool Move()
        {
            if (HasNext())
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (currentIndex < list.Count - 1)
            {
                return true;
            }

            return false;
        }

        public T Print()
        {
            if (list.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }

            return list[currentIndex];
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
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
