using System;
using System.Linq;

namespace _7._Group_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[][] jaggerdArray = new int[3][];

            int countOfZero = 0;
            int countOfOnes = 0;
            int countOfTwo = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    countOfZero++;
                }
                else if (numbers[i] % 3 == 1 || numbers[i] % 3 == -1)
                {
                    countOfOnes++;
                }
                else if (numbers[i] % 3 == 2 || numbers[i] % 3 == -2)
                {
                    countOfTwo++;
                }
            }

            int[] arrayZero = new int[countOfZero];
            int[] arrayOne = new int[countOfOnes];
            int[] arrayTwo = new int[countOfTwo];

            int zeroCounter = 0;
            int oneCounter = 0;
            int twoCounter = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {

                    arrayZero[zeroCounter] = numbers[i];
                    zeroCounter++;


                }
                else if (numbers[i] % 3 == 1 || numbers[i] % 3 == -1)
                {

                    arrayOne[oneCounter] = numbers[i];
                    oneCounter++;

                }
                else if (numbers[i] % 3 == 2 || numbers[i] % 3 == -2)
                {

                    arrayTwo[twoCounter] = numbers[i];
                    twoCounter++;

                }

            }

            for (int row = 0; row < 3; row++)
            {
                if (row == 0)
                {
                    jaggerdArray[row] = arrayZero;
                }
                else if (row == 1)
                {
                    jaggerdArray[row] = arrayOne;
                }
                else
                {
                    jaggerdArray[row] = arrayTwo;
                }
            }

            foreach (var array in jaggerdArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}