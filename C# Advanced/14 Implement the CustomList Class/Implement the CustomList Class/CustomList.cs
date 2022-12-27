using System;
using System.Collections.Generic;
using System.Text;

namespace Implement_the_CustomList_Class
{
    public class CustomList
    {
        private const int InitialCapacity = 2;

        private int[] items;
        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                Validation(index);

                return items[index];
            }
            set
            {
                Validation(index);

                items[index] = value;
            }
        }

        private void Validation(int index)
        {
            if (index > this.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }

        public void Add(int item)
        {
            if (this.Count == this.items.Length)
            {
                this.Resize();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];
            for (int i = 0; i < this.Count; i++)
            {
                copy[i] = this.items[i];
            }

            this.items = copy;
        }


        public int RemoveAt(int index)
        {
            Validation(index);

            var item = this.items[index];
            this.items[index] = default(int);
            this.Shift(index);

            this.Count--;

            if (this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }

            return item;
        }

        private void shiftToRight(int index)
        {
            for (int i = this.Count; i > 0; i--)
            {
                this.items[i] = this.items[i - 1];
            }

        }

        public void insert(int index, int element)
        {
            Validation(index);

            if (this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.shiftToRight(index);

            this.items[index] = element;
            this.Count++;

        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.items[i] == element)
                {
                    return true;
                }
                
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            Validation(firstIndex);
            Validation(secondIndex);

            int tempElemet = this.items[firstIndex];
            this.items[firstIndex] = this.items[secondIndex];
            this.items[secondIndex] = tempElemet;
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
