using System;
using System.Linq;

namespace _4._Matrix_Shuffling
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

            string[,] matrix = new string[rows, cols];

            EnteringAMatrix(rows, cols, matrix);

            string commands;

            while ((commands = Console.ReadLine()) != "END")
            {
                string[] cmdArguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                if (firstCommand == "swap" && cmdArguments.Length == 5)
                {
                    int rowOne = int.Parse(cmdArguments[1]);
                    int colOne = int.Parse(cmdArguments[2]);
                    int rowTwo = int.Parse(cmdArguments[3]);
                    int colTwo = int.Parse(cmdArguments[4]);

                    IsValid(rows, cols, matrix, rowOne, colOne, rowTwo, colTwo);

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }


        }

         static void EnteringAMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                string[] crrRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = crrRow[col];
                }

            }
        }

        static void IsValid(int rows, int cols, string[,] matrix, int rowOne, int colOne, int rowTwo, int colTwo)
        {
            if (rowOne >= 0 && rowOne < rows
                                    && colOne >= 0 && colOne < cols
                                    && rowTwo >= 0 && rowTwo < rows
                                    && colTwo >= 0 && colTwo < cols)
            {
                string crrElement = matrix[rowOne, colOne];
                matrix[rowOne, colOne] = matrix[rowTwo, colTwo];
                matrix[rowTwo, colTwo] = crrElement;

                PrintResult(rows, cols, matrix);

            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }

        static void PrintResult(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
