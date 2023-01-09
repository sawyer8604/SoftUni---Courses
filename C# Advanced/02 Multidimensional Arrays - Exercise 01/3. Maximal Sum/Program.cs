using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              .ToArray();

            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] crrRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }



            int rowsSquare = 3;
            int colsSquare = 3;

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;



            for (int row = 0; row < rows - rowsSquare + 1; row++)
            {
                for (int col = 0; col < cols - colsSquare + 1; col++)
                {
                    int crrSum = 0;

                    for (int i = 0; i < rowsSquare; i++)
                    {
                        for (int j = 0; j < colsSquare; j++)
                        {
                            crrSum += matrix[row + i, col + j];
                        }
                    }

                    if (crrSum > maxSum)
                    {
                        maxSum = crrSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRow; row < maxRow + rowsSquare; row++)
            {
                for (int col = maxCol; col < maxCol + colsSquare; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
           
        }
    }
    
}
