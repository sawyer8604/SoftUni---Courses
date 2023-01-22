using System;
using System.Collections.Generic;
using System.Text;

namespace CustomQueue
{
    public class CustomQueue
    {

        //• void Enqueue(int element) – Adds the given element to the queue
        //•	int Dequeue() – Removes the first element
        //•	int Peek() – Returns the first element in the queue without removing it
        //•	void Clear() – Delete all elements in the queue
        //•	void ForEach(Action<int> action) – Goes through each of the elements in the queue

        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;
        private int count;

        public CustomQueue()
        {
            this.items = new int[InitialCapacity];
            count = 0;
        }

        public int Count => count;

        public void Enqueue(int element)
        {
            if(items.Length == count)
            {
                Resize();
            }

            items[count] = element;
            count++;
        }

        public int Dequeue()
        {
            IsEmpty();
            int firstElement = items[FirstElementIndex];            
            SwitchElements();
            count--;
            Shrink();
            return firstElement;
        }

        public int Peek()
        {
            IsEmpty();

            int firstElemt = items[FirstElementIndex];

            return firstElemt;
        }

        public void Clear()
        {
            items = new int[InitialCapacity];
            count = 0;
        }

        public void ForEach(Action<int> action)
        {
            for(int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }

        private void IsEmpty()
        {
            if(count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
        }
        private void SwitchElements()
        {

            for (int i = 0; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            items[count - 1] = default(int);
        }

        private void Shrink()
        {
            int[] copyArray = new int[count + 2];

            if (items.Length > 2*count)
            {
                for (int i = 0; i < count; i++)
                {
                    copyArray[i] = items[i];
                }

                items = copyArray;
            }
        }
        private void Resize()
        {
            int[] copyArray = new int[count * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copyArray[i] = items[i];
            }
            items= copyArray;
        }
    }
}
