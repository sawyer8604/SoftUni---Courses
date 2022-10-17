using System;
using System.Linq;

namespace _07._Sum_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = Math.Max(firstArr.Length, secondArr.Length);

            int[] sumArray = new int[maxLength];

            for (int i = 0; i < maxLength; i++)
            {
                sumArray[i] = firstArr[i % firstArr.Length] + secondArr[i % secondArr.Length];
            }

            Console.WriteLine(String.Join(" ", sumArray));
        }
    }
}
