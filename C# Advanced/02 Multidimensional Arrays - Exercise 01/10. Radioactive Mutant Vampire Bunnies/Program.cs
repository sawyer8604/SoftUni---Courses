using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            int numberOfCoals = 0;

            int playerRow = 0;
            int playerCol = 0;

            List<int[]> bunnies = new List<int[]>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string crrRow = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = crrRow[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                    if (matrix[row, col] == 'B')
                    {
                        int[] crrRowCol = { row, col };

                        bunnies.Add(crrRowCol);
                    }
                }
            }

            string command = Console.ReadLine();
            bool IsDeath = false;
            bool isWon = false;
            matrix[playerRow, playerCol] = '.';

            for (int i = 0; i < command.Length; i++)
            {
                char firstCommand = command[i];

                int nextRow = 0;
                int nextCol = 0;

                switch (firstCommand)
                {

                    case 'U':
                        nextRow = -1;

                        break;

                    case 'L':
                        nextCol = -1;

                        break;

                    case 'R':
                        nextCol = 1;

                        break;

                    case 'D':
                        nextRow = 1;

                        break;
                }


                if (IsOutOfRange(matrix, playerRow + nextRow, playerCol + nextCol))
                {
                    isWon = true;
                }
                else
                {
                    playerRow += nextRow;
                    playerCol += nextCol;
                }

                if (matrix[playerRow, playerCol] == 'B')
                {
                    IsDeath = true;
                }

                foreach (var bunny in bunnies)
                {
                    int crrBunnyRow = bunny[0];
                    int crrBunnycol = bunny[1];


                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {

                            if (row == crrBunnyRow && col == crrBunnycol)
                            {
                                //left
                                if (crrBunnycol - 1 >= 0)
                                {
                                    matrix[crrBunnyRow, crrBunnycol - 1] = 'B';
                                }

                                // right
                                if (crrBunnycol + 1 < cols)
                                {
                                    matrix[crrBunnyRow, crrBunnycol + 1] = 'B';
                                }
                                // up
                                if (crrBunnyRow - 1 >= 0)
                                {
                                    matrix[crrBunnyRow - 1, crrBunnycol] = 'B';

                                }
                                // down

                                if (crrBunnyRow + 1 < rows)
                                {
                                    matrix[crrBunnyRow + 1, crrBunnycol] = 'B';

                                }


                            }

                        }
                    }
                }

                if (isWon)
                {
                    Print(matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    return;
                }

                if (IsDeath)
                {                   
                    Print(matrix);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    return;
                }

                for (int row = 0; row < matrix.GetLength(0); row++)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            int[] crrRowCol = { row, col };

                            bunnies.Add(crrRowCol);
                        }
                    }
                }

            }
            
        }

        static bool IsOutOfRange(char[,] matrix, int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
