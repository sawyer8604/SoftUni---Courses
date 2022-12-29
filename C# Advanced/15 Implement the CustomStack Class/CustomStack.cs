using System;
using System.Collections.Generic;
using System.Text;

namespace _2._Implement_the_CustomStack_Class
{
    public class CustomStack
    {
        const int InitialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            this.count = 0;
            this.items = new int[InitialCapacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }


        public void Push(int element)
        {
            if(this.items.Length == this.count)
            {
                var nextItem = new int[this.items.Length * 2];

                for (int i = 0; i < this.items.Length; i++)
                {
                    nextItem[i] = this.items[i];
                }
                this.items = nextItem;
            }

            this.items[this.count] = element;

            count++;
        }

        public int Pop()
        {

            if(this.count == 0)
            {
                throw new InvalidOperationException("CustomStack is Empty");
            }

            var lastIndex = this.count - 1;
            int last = this.items[lastIndex];
            this.items[this.count - 1] = default(int);
            this.count--;
            return last;
        }

        public int Peek()
        {

            if (this.count == 0)
            {
                throw new InvalidOperationException("CustomStack is Empty");
            }

            var lastIndex = this.count - 1;
            int last = this.items[lastIndex];
            return last;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this.Count; i++)
            {
                int currentItem = this.items[i];

                action(currentItem);
            }
        }
    }
}
