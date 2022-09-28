using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> firstNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int maxCount = Math.Max(firstNums.Count, secondNums.Count);

            for (int i = 0; i < maxCount; i++)
            {
                if(firstNums.Count > i)
                {
                    result.Add(firstNums[i]);
                }

                if(secondNums.Count > i)
                {
                    result.Add(secondNums[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
