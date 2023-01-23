using System;

namespace _02.GenericBoxofInteger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLinse = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < numberOfLinse; i++)
            {
                int number = int.Parse(Console.ReadLine());

                box.Items.Add(number);
            }
            Console.WriteLine(box.ToString());
        }
    }
}
