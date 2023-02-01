using System;
using System.Linq;

namespace _02._Rally_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int trackedCarRow = 0;
            int trackedCarCol = 0;

            int moves = 0;

            int tunelRow = 0;
            int tunelCol = 0;

            string racingCarNumber = Console.ReadLine();

            for (int row = 0; row < size; row++)
            {
                char[] crrRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = crrRow[col];

                }
            }

            
            string command;

            while (true)
            {
                command = Console.ReadLine();

                switch (command)
                {
                    case "left":

                        if (trackedCarCol - 1 >= 0)
                        {
                            trackedCarCol -= 1;
                            if (matrix[trackedCarRow, trackedCarCol] == '.')
                            {
                                moves += 10;
                            }
                        }

                        break;

                    case "right":

                        if (trackedCarCol + 1 < matrix.GetLength(0))
                        {

                            trackedCarCol += 1;

                            if (matrix[trackedCarRow, trackedCarCol] == '.')
                            {
                                moves += 10;
                            }
                        }

                        break;

                    case "up":

                        if (trackedCarRow - 1 >= 0)
                        {
                            trackedCarRow -= 1;

                            if (matrix[trackedCarRow, trackedCarCol] == '.')
                            {
                                moves += 10;
                            }
                        }

                        break;

                    case "down":

                        if (trackedCarRow + 1 < matrix.GetLength(0))
                        {
                            trackedCarRow += 1;

                            if (matrix[trackedCarRow, trackedCarCol] == '.')
                            {
                                moves += 10;
                            }
                        }

                        break;


                }

                if (command == "End")
                {

                    Console.WriteLine($"Racing car {racingCarNumber} DNF.");
                    Console.WriteLine($"Distance covered {moves} km.");

                    matrix[trackedCarRow, trackedCarCol] = 'C';
                    Print(matrix);
                    return;
                }

                if (matrix[trackedCarRow, trackedCarCol] == 'T')
                {
                    matrix[trackedCarRow, trackedCarCol] = '.';

                    for (int row = 0; row < size; row++)
                    {

                        for (int col = 0; col < size; col++)
                        {
                            if (matrix[row, col] == 'T')
                            {
                                trackedCarRow = row;
                                trackedCarCol = col;
                            }

                        }
                    }

                    matrix[trackedCarRow, trackedCarCol] = '.';

                    moves += 30;
                }

                if (matrix[trackedCarRow, trackedCarCol] == 'F')
                {
                    moves += 10;
                    matrix[trackedCarRow, trackedCarCol] = 'C';
                    Console.WriteLine($"Racing car {racingCarNumber} finished the stage!");
                    Console.WriteLine($"Distance covered {moves} km.");
                    Print(matrix);

                    return;

                }
            }

        }
        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
