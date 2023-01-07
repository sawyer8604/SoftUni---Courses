using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] crrRow = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }


            for (int col = 0; col < cols; col++)
            {
                int crrColumsSum = 0;

                for (int row = 0; row < rows; row++)
                {
                    crrColumsSum += matrix[row, col];
                }

                Console.WriteLine(crrColumsSum);
            }
        }
    }
}
