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

            for (int row = 0; row < size; row++)
            {
                int[] crrRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }

            int leftDiagonalSum = 0;

            int rightDiagonalSum = 0;

            for (int row = 0; row < size; row++)
            {

                leftDiagonalSum += matrix[row, row];

                rightDiagonalSum += matrix[row, size - 1 - row];

            }

            int difference = Math.Abs(leftDiagonalSum - rightDiagonalSum);
            Console.WriteLine(difference);
        }
    }
}
