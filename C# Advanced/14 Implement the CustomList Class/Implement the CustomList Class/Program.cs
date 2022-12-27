using System;

namespace Implement_the_CustomList_Class
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();

            list.Add(1);
            list.Add(200);
            list.Add(30);

            Console.WriteLine(list.Count);

            Console.WriteLine(list.RemoveAt(1));
            Console.WriteLine(list.RemoveAt(0));
            Console.WriteLine(list.RemoveAt(0));


            list.insert(0, 20);

            Console.WriteLine(list.Contains(20));
            Console.WriteLine(list.Contains(21));

            list.Add(15);
            list.Add(33);
            list.Add(26);

            list.Swap(0, 2);

            list.ForEach(i => Console.Write($"{i} "));
            Console.WriteLine();
        }
    }
}
