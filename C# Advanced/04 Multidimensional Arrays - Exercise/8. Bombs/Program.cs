using System;
using System.Data;
using System.Linq;

namespace _8._Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] crrRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }


            string[] bombCells = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < bombCells.Length; i++)
            {
                string crrCellsNumber = bombCells[i].ToString();

                int[] crrCells = crrCellsNumber.Split(",").Select(int.Parse).ToArray();

                int crrRow = crrCells[0];
                int crrCol = crrCells[1];

                bool isEqual = false;

                for (int row = 0; row < size; row++)
                {

                    for (int col = 0; col < size; col++)
                    {

                        if (row == crrRow && col == crrCol)
                        {
                            if (matrix[row, col] > 0)
                            {
                                isEqual = true;

                                int cell = matrix[row, col];

                                matrix[row, col] = 0;

                                // left

                                if (col - 1 >= 0)
                                {
                                    if (matrix[row, col - 1] != 0)
                                    {
                                        matrix[row, col - 1] -= cell;
                                    }

                                }

                                // right 

                                if (col + 1 < size)
                                {
                                    if (matrix[row, col + 1] > 0)
                                    {
                                        matrix[row, col + 1] -= cell;
                                    }
                                }

                                // up

                                if (row - 1 >= 0)
                                {
                                    if (matrix[row - 1, col] > 0)
                                    {
                                        matrix[row - 1, col] -= cell;
                                    }
                                }

                                // down 

                                if (row + 1 < size)
                                {
                                    if (matrix[row + 1, col] > 0)
                                    {
                                        matrix[row + 1, col] -= cell;

                                    }
                                }

                                //left - up diagonal

                                if (row - 1 >= 0 && col - 1 >= 0)
                                {
                                    if (matrix[row - 1, col - 1] > 0)
                                    {
                                        matrix[row - 1, col - 1] -= cell;
                                    }
                                }

                                // left Down diagonal

                                if (row + 1 < size && col - 1 >= 0)
                                {
                                    if (matrix[row + 1, col - 1] > 0)
                                    {
                                        matrix[row + 1, col - 1] -= cell;
                                    }

                                }

                                // right up diagonal

                                if (row - 1 >= 0 && col + 1 < size)
                                {
                                    if (matrix[row - 1, col + 1] > 0)
                                    {
                                        matrix[row - 1, col + 1] -= cell;
                                    }
                                }

                                // right down diagonal

                                if (row + 1 < size && col + 1 < size)
                                {
                                    if (matrix[row + 1, col + 1] > 0)
                                    {
                                        matrix[row + 1, col + 1] -= cell;
                                    }
                                }
                            }
                        }

                        if (isEqual)
                        {
                            break;
                        }
                    }

                    if (isEqual)
                    {
                        break;
                    }
                }


            }

            int sum = 0;
            int aliveCells = 0;
            
            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        sum += matrix[row, col];
                        aliveCells++;
                    }
                }

            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");


            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
