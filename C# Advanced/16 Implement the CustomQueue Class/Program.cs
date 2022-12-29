using System;

namespace _3._Implement_the_CustomQueue_Class
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            CustomQueue queue= new CustomQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue();

            Console.WriteLine(queue.Peek());

            queue.Clear();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(2);

            queue.ForEach(n => Console.Write($"{n} "));
        }
    }
}
