using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();


            if (arr.Length <= 1)
            {

                Console.Write($"{{ ");
                Console.Write($"{arr[0]}");
                Console.Write($" }}");

            }
            else if (arr.Length % 2 == 0)
            {
                int[] evenArr = new int[2];



                evenArr[0] = arr[arr.Length / 2 - 1];
                evenArr[1] = arr[arr.Length / 2];

                int firstElement = evenArr[0];
                int secondElement = evenArr[1];

                Console.Write($"{{ ");
                Console.Write($"{firstElement}, {secondElement}");
                Console.Write($" }}");
            }
            else
            {
                int[] oddArr = new int[3];

                oddArr[0] = arr[arr.Length / 2 - 1];
                oddArr[1] = arr[arr.Length / 2];
                oddArr[2] = arr[arr.Length / 2 + 1];

                int firstElementOdd = oddArr[0];
                int secondElementOdd = oddArr[1];
                int thirdElementOdd = oddArr[2];

                Console.Write($"{{ ");
                Console.Write($"{firstElementOdd}, {secondElementOdd}, {thirdElementOdd}");
                Console.Write($" }}");
            }


        }
    }
}
