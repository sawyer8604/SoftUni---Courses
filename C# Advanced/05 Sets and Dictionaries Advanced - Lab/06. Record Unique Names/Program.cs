using System;
using System.Collections.Generic;

namespace _06._Record_Unique_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
