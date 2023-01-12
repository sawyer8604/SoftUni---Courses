using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] element = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in element)
                {
                    elements.Add(item);
                }
            }
            
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
