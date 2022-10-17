using System;
using System.Linq;

namespace _03._Last_K_Numbers_Sums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int countToSum = int.Parse(Console.ReadLine());

            long[] arr = new long[numbers];
            arr[0] = 1;

            for (int i = 1; i < numbers; i++)
            {
                long sum = 0;
                int startIndex = Math.Max(0, i - countToSum);

                for (int j = startIndex; j < i; j++)
                {
                    sum += arr[j];
                }

                arr[i] = sum;
            }

            Console.WriteLine(String.Join(" ", arr));

        }
    }
}
