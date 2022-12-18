using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            HashSet<string> uniqueElements = new HashSet<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] chemicalCompounds = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < chemicalCompounds.Length; j++)
                {
                    string crrElemet = chemicalCompounds[j];

                    uniqueElements.Add(crrElemet);
                }
            }

            uniqueElements = uniqueElements.OrderBy(x => x).ToHashSet();

            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
