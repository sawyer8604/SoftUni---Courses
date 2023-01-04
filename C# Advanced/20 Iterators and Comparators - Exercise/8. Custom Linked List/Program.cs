namespace CustomDoublyLinkedList
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            CustomDoublyLinkedList<int> customLinkedList = new CustomDoublyLinkedList<int>();

            customLinkedList.AddLast(1);
            customLinkedList.AddLast(2);
            customLinkedList.AddLast(3);
            customLinkedList.AddFirst(4);

            foreach (var item in customLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}