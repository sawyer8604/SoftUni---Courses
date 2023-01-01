using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box= new Box<string>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                box.Items.Add(input);
            }

            string inputToCompare = Console.ReadLine();

            Console.WriteLine(box.Count(inputToCompare));

        }
    }
}
