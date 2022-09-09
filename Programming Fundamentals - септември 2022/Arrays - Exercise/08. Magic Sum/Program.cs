using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == number)
                    {
                        int firstNum = arr[i];
                        int secondNum = arr[j];

                        Console.WriteLine($"{firstNum} {secondNum}");
                    }

                }

            }


        }
    }
}
