using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            

            for (int i = 0; i < arr.Length; i++)
            {               
                bool currentIterationNumIsBigger = true;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        currentIterationNumIsBigger = false;
                        break;
                    }

                }
                if(currentIterationNumIsBigger)
                {
                    Console.Write($"{arr[i]} ");
                }


            }
            



        }

    }
}
