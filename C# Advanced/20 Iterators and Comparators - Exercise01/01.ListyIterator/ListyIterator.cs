using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        List<T> list;
        int currentIndex = 0;
        public ListyIterator(List<T> list)
        {
            this.list = list;
        }

        public bool Move()
        {
            if(HasNext())
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
            if(list.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }

            return list[currentIndex];
        }
    }
}
