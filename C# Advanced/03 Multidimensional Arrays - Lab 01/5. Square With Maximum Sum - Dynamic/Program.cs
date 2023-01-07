using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum___Dynamic
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
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }

            int[] squareSize = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .ToArray();

            int rowsSquare = squareSize[0];
            int colsSquare = squareSize[1];

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
                            crrSum += matrix[row +i, col +j];
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

            for (int row = maxRow; row < maxRow + rowsSquare; row++)
            {
                for (int col = maxCol; col < maxCol + colsSquare; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxSum);
        }
    }
}
