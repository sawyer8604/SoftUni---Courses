using System;
using System.Linq;

namespace _9._Miner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            string commands = Console.ReadLine();

            int numberOfCoals = 0;

            int minerRow = 0;
            int minerCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] crrRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = crrRow[col];

                    if (matrix[row, col] == 'c')
                    {
                        numberOfCoals++;
                    }

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                }
            }

            string[] cmdArguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < cmdArguments.Length; i++)
            {
                string firstCommand = cmdArguments[i];

                int nextRow = 0;
                int nextCol = 0;

                switch (firstCommand)
                {

                    case "up":
                        nextRow = -1;

                        break;

                    case "left":
                        nextCol = -1;

                        break;

                    case "right":
                        nextCol = 1;

                        break;

                    case "down":
                        nextRow = 1;

                        break;
                }

                if (!IsValid(matrix, minerRow + nextRow, minerCol + nextCol))
                {
                    continue;
                }

                minerRow += nextRow;
                minerCol += nextCol;

                if (matrix[minerRow, minerCol] == 'c')
                {
                    numberOfCoals--;

                    matrix[minerRow, minerCol] = 's';
                    matrix[minerRow, minerCol] = '*';

                    if (numberOfCoals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        return;
                    }
                }
                else if (matrix[minerRow, minerCol] == 'e')
                {

                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    return;
                }
                else
                {
                    matrix[minerRow, minerCol] = 's';
                    matrix[minerRow, minerCol] = '*';
                }
                                                
            }

            Console.WriteLine($"{numberOfCoals} coals left. ({minerRow}, {minerCol})");
        }

        static bool IsValid(char[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
