using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> mixedList = new List<int>();

            int minCount = Math.Min(firstList.Count, secondList.Count);
            int maxCount = Math.Max(firstList.Count, secondList.Count);

            int count = 0;

            while (minCount > 0)
            {
                minCount--;
                maxCount--;

                if (firstList.Count > secondList.Count)
                {
                    mixedList.Add(firstList[count]);
                    mixedList.Add(secondList[minCount]);

                    firstList.RemoveAt(count);
                    secondList.RemoveAt(minCount);
                }
                else
                {
                    mixedList.Add(firstList[count]);
                    mixedList.Add(secondList[maxCount]);

                    firstList.RemoveAt(count);
                    secondList.RemoveAt(maxCount);

                }
            }

            if(firstList.Count > 0)
            {
                int firstElement = firstList[0];
                int secondElement = firstList[1];
                int maxElement = Math.Max(secondElement, firstElement);
                int minElement = Math.Min(secondElement, firstElement);

                mixedList.Sort();

                for (int i = 0 + 1; i < mixedList.Count; i++)
                {
                    if (mixedList[i] > minElement && mixedList[i] < maxElement)
                    {
                        Console.Write($"{mixedList[i]} ");
                    }
                    
                }
            }
            else
            {
                int firstElement = secondList[0];
                int secondElement = secondList[1];
                int maxElement = Math.Max(secondElement, firstElement);
                int minElement = Math.Min(secondElement, firstElement);

                mixedList.Sort();

                for (int i = 0 + 1; i < mixedList.Count; i++)
                {
                    if (mixedList[i] > minElement && mixedList[i] < maxElement)
                    {
                        Console.Write($"{mixedList[i]} ");
                    }

                }

            }
        }
    }
}
