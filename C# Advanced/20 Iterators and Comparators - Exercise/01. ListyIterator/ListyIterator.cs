using System;
using System.Collections.Generic;
using System.Text;

namespace _01._ListyIterator
{
    internal class ListyIterator<T>
    {
        
        int index;
        List<T> items;

        public ListyIterator(List<T> items)
        {
            this.items = items;
        }        


        public bool move()
        {
            if(index < items.Count - 1)
            {
                index++;
                return true;
            }
            return false;

        }

        public bool HasNext()
        {
            return index < items.Count - 1;

        }

        public void Print()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Console.WriteLine(items[index]);
        }
    }
}
