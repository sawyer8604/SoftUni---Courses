using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
