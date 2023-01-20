using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace CustomDoublyLinkedList01
{
    public class DoublyLinkedList
    {
        private class ListNode
        {
            public ListNode(int value)
            {
                Value = value;
            }

            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
            public int Value { get; set; }

        }

        ListNode head;
        ListNode tail;

        public int Count // Read-only property (get only)
        {
            
            get
            {
                int count = 0;

                ListNode crrElement = head;

                while (crrElement != null)
                {
                    count++;
                    crrElement = crrElement.NextNode;
                }

                return count;
            }

        } 


        //•	void AddFirst(int element) – adds an element at the beginning of the collection
        //•	void AddLast(int element) – adds an element at the end of the collection
        //•	int RemoveFirst() – removes the element at the beginning of the collection
        //•	int RemoveLast() – removes the element at the end of the collection
        //•	void ForEach() – goes through the collection and executes a given action
        //•	int[] ToArray() – returns the collection as an array

        public void AddFirst(int element)
        {
            ListNode newElement = new ListNode(element);

            if (head == null)
            {
                head = newElement;
                tail = newElement;
            }
            else
            {
                newElement.NextNode = head;
                head.PreviousNode = newElement;
                head = newElement;
            }

        }

        public void AddLast(int element)
        {
            ListNode newElement = new ListNode(element);

            if (head == null)
            {
                head = newElement;
                tail = newElement;
            }
            else
            {
                newElement.PreviousNode = tail;
                tail.NextNode = newElement;
                tail = newElement;
            }

        }
        public int RemoveFirst()
        {
            if(head == null)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            int currentFirstValue = head.Value;

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {

                ListNode newFirst = head.NextNode;
                newFirst.PreviousNode = null;
                head = newFirst;
            }

            return currentFirstValue;
        }

        public int RemoveLast()
        {
            if (tail == null)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            int currentLastValue = head.Value;

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {

                ListNode newLast = tail.PreviousNode;
                newLast.NextNode = null;
                tail = newLast;

            }

            return currentLastValue;
        }

        public void  ForEach(Action<int> action)
        {
            ListNode crrElement = head;

            while (crrElement != null)
            {
                action(crrElement.Value);
                crrElement = crrElement.NextNode;
            }

        }


        public int[] ToArray()
        {
            ListNode crrElement = head;

            int[] array = new int[Count];
            int count = 0;

            while (crrElement != null)
            {
                array[count] = crrElement.Value;
                count++;
                crrElement= crrElement.NextNode;
            }

            return array;
        }
    }
}
