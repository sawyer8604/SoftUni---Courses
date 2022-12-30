using System;

namespace _02.GenericBoxofInteger
{
    internal class StartUp
    {
        static void Main(string[] args)
        {

            int numberOfLine = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < numberOfLine; i++)
            {
                int input = int.Parse(Console.ReadLine());

                box.Items.Add(input);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
