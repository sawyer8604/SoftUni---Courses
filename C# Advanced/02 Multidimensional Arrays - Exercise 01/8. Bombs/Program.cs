using System;
using System.Linq;

namespace _8._Bombs
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


            int[] coordinates = Console.ReadLine()
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            for (int i = 0; i < coordinates.Length; i += 2)
            {
                int crrRow = coordinates[i];
                int crrCol = coordinates[i + 1];

                int bomb = matrix[crrRow, crrCol];


                if (matrix[crrRow, crrCol] > 0)
                {
                    // up
                    if (crrRow - 1 >= 0)
                    {
                        if (IsValid(matrix, crrRow - 1, crrCol) && matrix[crrRow - 1, crrCol] > 0)
                        {
                            matrix[crrRow - 1, crrCol] -= matrix[crrRow, crrCol];
                           
                        }
                    }

                    //up - right
                    if (crrRow - 1 >= 0 && crrCol + 1 < size)
                    {
                        if (IsValid(matrix, crrRow - 1, crrCol + 1) && matrix[crrRow - 1, crrCol + 1] > 0)
                        {
                            matrix[crrRow - 1, crrCol + 1] -= matrix[crrRow, crrCol];
                            
                        }
                    }

                    // right
                    if (crrCol + 1 < size)
                    {
                        if (IsValid(matrix, crrRow, crrCol + 1) && matrix[crrRow, crrCol + 1] > 0)
                        {
                            matrix[crrRow, crrCol + 1] -= matrix[crrRow, crrCol];
                           
                        }
                    }

                    //right - down
                    if (crrRow + 1 < size && crrCol + 1 < size)
                    {
                        if (IsValid(matrix, crrRow + 1, crrCol + 1) && matrix[crrRow + 1, crrCol + 1] > 0)
                        {
                            matrix[crrRow + 1, crrCol + 1] -= matrix[crrRow, crrCol];
                            
                        }
                    }

                    // down
                    if (crrRow + 1 < size)
                    {
                        if (IsValid(matrix, crrRow + 1, crrCol) && matrix[crrRow + 1, crrCol] > 0)
                        {
                            matrix[crrRow + 1, crrCol] -= matrix[crrRow, crrCol];
                            
                        }
                    }

                    // down left
                    if (crrRow + 1 < size && crrCol - 1 >= 0)
                    {

                        if (IsValid(matrix, crrRow + 1, crrCol - 1) && matrix[crrRow + 1, crrCol - 1] > 0)
                        {
                            matrix[crrRow + 1, crrCol - 1] -= matrix[crrRow, crrCol];                            
                        }
                    }

                    //left
                    if (crrCol - 1 >= 0)
                    {


                        if (IsValid(matrix, crrRow, crrCol - 1) && matrix[crrRow, crrCol - 1] > 0)
                        {
                            matrix[crrRow, crrCol - 1] -= matrix[crrRow, crrCol];

                        }
                    }

                    //left up
                    if (crrRow - 1 >= 0 && crrCol - 1 >= 0)
                    {
                        if (IsValid(matrix, crrRow - 1, crrCol - 1) && matrix[crrRow - 1, crrCol - 1] > 0)
                        {
                            matrix[crrRow - 1, crrCol - 1] -= matrix[crrRow, crrCol];
                        }
                    }

                    matrix[crrRow, crrCol] = 0;

                }

            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }

                }

            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }

        }

        static bool IsValid(int[,] matrix, int crrRow, int crrCol)
        {
            return matrix[crrRow, crrCol] > 0;
        }
    }
}
