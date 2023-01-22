using System;

namespace CustomQueue
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            CustomQueue queue = new CustomQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            int element = queue.Peek();
            Console.WriteLine(element);

            queue.ForEach(x => Console.WriteLine(x));
            queue.Clear();
        }
    }
}
