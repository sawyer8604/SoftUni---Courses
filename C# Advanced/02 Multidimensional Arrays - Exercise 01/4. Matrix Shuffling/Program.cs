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

            for (int row = 0; row < rows; row++)
            {
                string[] crrRow = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmdArguments[0] != "swap" || cmdArguments.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(cmdArguments[1]);
                int col1 = int.Parse(cmdArguments[2]);

                int row2 = int.Parse(cmdArguments[3]);
                int col2 = int.Parse(cmdArguments[4]);

                if (row1 < 0 || row1 >= rows || col1 < 0 || col1 >= cols || row2 < 0 || row2 >= rows || col2 < 0 || col2 >= cols)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string crrElement = matrix[row1, col1];
                matrix[row1, col1] = matrix[row2, col2];
                matrix[row2, col2] = crrElement;

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
}
