using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);

            list.RemoveFirst();
            list.RemoveLast();

            list.ForEach(Console.WriteLine);
        }
    }
}
