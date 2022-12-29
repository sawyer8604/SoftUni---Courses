using System;
using System.Collections.Generic;
using System.Text;

namespace _3._Implement_the_CustomQueue_Class
{
    public class CustomQueue
    {

        const int InitialCapacity = 4;
        private int[] items;
        private int count;

        public CustomQueue()
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

        public void Enqueue(int element)
        {
            if (this.items.Length == this.count)
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

        public int Dequeue()
        {

            if (this.count == 0)
            {
                throw new InvalidOperationException("CustomStack is Empty");
            }

            var firstIndex = 0;
            int first = this.items[firstIndex];
            this.items[0] = default(int);
            

            for (int i = 0; i < this.count; i++)
            {
                this.items[i] = this.items[i + 1];
            }

            this.items[this.count] = default(int);

            this.count--;

            return first;
        }

        public int Peek()
        {

            if (this.count == 0)
            {
                throw new InvalidOperationException("CustomStack is Empty");
            }

            var firstIndex = 0;
            int first = this.items[firstIndex];
            
            return first;
        }

        public int Clear()
        {
            this.count = 0;
            this.items = new int[InitialCapacity];

            return count;

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
