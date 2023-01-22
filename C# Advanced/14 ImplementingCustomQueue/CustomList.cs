﻿using System;
using System.Collections.Generic;

namespace CustomStructures
{
    public class CustomList
    {
        private int[] elements;
        private int internalCounter;

        public CustomList()
        {
            elements = new int[2];
            internalCounter = 0;
        }

        public int Count
            => internalCounter;

        public int this[int i]
        {
            get
            {
                EnsureIsInRange(i);
                return elements[i];
            }
            set
            {
                EnsureIsInRange(i);
                elements[i] = value;
            }
        }

        public void Add(int element)
        {
            Resize();
            elements[internalCounter] = element;
            internalCounter++;
        }

        public void Shrink()
        {
            int[] newArray = new int[internalCounter];

            for (int i = 0; i < internalCounter; i++)
            {
                newArray[i] = elements[i];
            }

            elements = newArray;
        }

        public int RemoveAt(int index)
        {
            EnsureIsInRange(index);

            int number = elements[index];

            internalCounter--;

            for (int i = index; i < internalCounter; i++)
            {
                elements[i] = elements[i + 1];
            }

            return number;
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(elements[i]);
            }
            
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < internalCounter; i++)
            {
                if (elements[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            EnsureIsInRange(firstIndex);
            EnsureIsInRange(secondIndex);

            int firstElement = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = firstElement;
        }

        private void EnsureIsInRange(int i)
        {
            if (i < 0 || i >= internalCounter)
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void Resize()
        {
            if (elements.Length == internalCounter)
            {
                int[] copyArray = new int[elements.Length * 2];

                for (int i = 0; i < elements.Length; i++)
                {
                    copyArray[i] = elements[i];
                }

                elements = copyArray;
            }
        }
    }
}