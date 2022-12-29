using System;

namespace _2._Implement_the_CustomStack_Class
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack customStack = new CustomStack();

            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            customStack.Push(4);

            customStack.Pop();
           
            Console.WriteLine(customStack.Peek());

            customStack.ForEach(x => Console.WriteLine(x));
        }
    }
}
