using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];

                }
            }
            int maxSum = 0;

            int maxFirst = 0;
            int maxSecond = 0;
            int maxThird = 0;
            int maxFouth = 0;
            

            for (int row = 0; row < rows - 1; row++)
            {

                for (int col = 0; col < cols - 1; col++)
                {
                    int sum = 0;

                    int firstNum = matrix[row, col];
                    int secondNum = matrix[row, col + 1];

                    int thirdNum = matrix[row + 1, col];
                    int fouthNum = matrix[row + 1, col + 1];


                    sum += firstNum + secondNum;
                    sum += thirdNum + fouthNum;

                    if (sum > maxSum)
                    {
                        maxSum = sum;

                        maxFirst = firstNum;
                        maxSecond = secondNum;
                        maxThird = thirdNum;
                        maxFouth = fouthNum;

                    }
                }
            }


            Console.WriteLine($"{maxFirst} {maxSecond}");
            Console.WriteLine($"{maxThird} {maxFouth}");

            Console.WriteLine(maxSum);
        }
    }
}
