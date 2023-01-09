using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] crrRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }

            int lefRightsum = 0;
            int rightLeftSum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                lefRightsum += matrix[i, i];

                rightLeftSum += matrix[i, matrix.GetLength(0) - 1 - i]; //or size -1 -i

            }

            int difference = Math.Abs(lefRightsum - rightLeftSum);

            Console.WriteLine(difference);
        }
    }
}
