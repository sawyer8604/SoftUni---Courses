using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists_Second_Way
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            List<int> firstNums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int minCount = Math.Min(firstNums.Count, secondNums.Count);

            for (int i = 0; i < minCount; i++)
            {
                result.Add(firstNums[i]);
                result.Add(secondNums[i]);                               

            }
            if (firstNums.Count > secondNums.Count)
            {
                result.AddRange(GetRemainingElements(firstNums, secondNums));
            }
            else if (secondNums.Count > firstNums.Count)
            {
                result.AddRange(GetRemainingElements(secondNums, firstNums));
            }
            Console.WriteLine(String.Join(" ", result));
        }

        static List<int> GetRemainingElements(List<int> longerList , List<int> shorterList)
        {
            List<int> nums = new List<int>();
            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                nums.Add(longerList[i]);

            }
            return nums;
        }
    }
}
