using System;
using System.Linq;

namespace _04._Triple_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long sum = 0;
            bool isSumEqual = false;

            for (int i = 0; i < arr.Length; i++)
            {

                for (int k = i + 1; k < arr.Length; k++)
                {
                    sum = arr[i] + arr[k];

                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (sum == arr[j])
                        {
                            Console.WriteLine($"{arr[i]} + {arr[k]} == {arr[j]}");
                            isSumEqual = true;
                            break;
                        }

                    }
                }             

            }

            if(!isSumEqual)
            {
                Console.WriteLine("No");
            }
        }
    }
}
