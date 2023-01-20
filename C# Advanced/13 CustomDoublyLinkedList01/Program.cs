using CustomDoublyLinkedList01;
using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            DoublyLinkedList customList = new DoublyLinkedList();
            
            customList.AddFirst(3);  
            customList.AddFirst(2);
            customList.AddFirst(1);  
            customList.AddLast(4);
            customList.AddLast(100);
            customList.AddFirst(100);

            Console.WriteLine(string.Join(" ", customList.ToArray()));

            customList.RemoveFirst();

            Console.WriteLine(string.Join(" ", customList.ToArray()));

            customList.RemoveLast();

            Console.WriteLine(string.Join(" ", customList.ToArray()));

            customList.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(string.Join(" ", customList.ToArray()));

        }
    }
}
