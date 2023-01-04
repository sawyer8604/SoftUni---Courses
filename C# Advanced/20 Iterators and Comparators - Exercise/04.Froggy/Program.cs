using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                 .Split(", ")
                 .Select(int.Parse)
                 .ToList();

            Lake<int> lake = new Lake<int>(input);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
