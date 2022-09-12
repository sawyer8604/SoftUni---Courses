using System;

namespace _02._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Console.WriteLine("1");

            if (lines == 1)
            {

                return;
            }

            int[] initialArr =
            {
                1,
                1
            };
            Console.WriteLine(String.Join(" ", initialArr));

            if (lines == 2)
            {
                return;
            }

            for (int i = 3; i <= lines; i++)
            {
                int[] nextArr = new int[initialArr.Length + 1];

                for (int j = 1; j < nextArr.Length - 1; j++)
                {
                    nextArr[0] = 1;
                    nextArr[nextArr.Length - 1] = 1;

                    nextArr[j] = initialArr[j - 1] + initialArr[j];
                }
                Console.WriteLine(string.Join(" ", nextArr));
                initialArr = nextArr;


            }
        }
    }
}
