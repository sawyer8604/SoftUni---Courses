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

            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int row = 0; row < size; row++)
            {
                char[] crrRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => char.Parse(n))
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }

            int crRow = 0;
            int crrCol = 0;
            int coalCount = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] == 's')
                    {
                        crRow = row;
                        crrCol = col;
                    }

                    if (matrix[row, col] == 'c')
                    {
                        coalCount++;
                    }

                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string command = commands[i];

                if (command == "left")
                {
                    if (crrCol - 1 >= 0)
                    {
                        if (matrix[crRow, crrCol - 1] == '*')
                        {
                            matrix[crRow, crrCol - 1] = 's';
                            matrix[crRow, crrCol] = '*';
                            crrCol = crrCol - 1;
                            continue;
                        }

                        if (matrix[crRow, crrCol - 1] == 'c')
                        {
                            coalCount--;

                            matrix[crRow, crrCol - 1] = 's';
                            matrix[crRow, crrCol] = '*';
                            crrCol = crrCol - 1;

                            if (coalCount == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({crRow}, {crrCol})");
                                return;
                            }

                            continue;

                        }
                        else if (matrix[crRow, crrCol - 1] == 'e')
                        {

                            crrCol = crrCol - 1;
                            Console.WriteLine($"Game over! ({crRow}, {crrCol})");
                            return;
                        }

                    }
                }
                else if (command == "right")
                {
                    if (crrCol + 1 < size)
                    {
                        if (matrix[crRow, crrCol + 1] == '*')
                        {
                            matrix[crRow, crrCol + 1] = 's';
                            matrix[crRow, crrCol] = '*';
                            crrCol = crrCol + 1;
                            continue;
                        }

                        if (matrix[crRow, crrCol + 1] == 'c')
                        {
                            coalCount--;

                            matrix[crRow, crrCol + 1] = 's';
                            matrix[crRow, crrCol] = '*';
                            crrCol = crrCol + 1;

                            if (coalCount == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({crRow}, {crrCol})");
                                return;
                            }

                            continue;

                        }

                        if (matrix[crRow, crrCol + 1] == 'e')
                        {

                            crrCol = crrCol + 1;
                            Console.WriteLine($"Game over! ({crRow}, {crrCol})");
                            return;
                        }

                    }
                }
                else if (command == "up")
                {
                    if (crRow - 1 >= 0)
                    {
                        if (matrix[crRow - 1, crrCol] == '*')
                        {
                            matrix[crRow - 1, crrCol] = 's';
                            matrix[crRow, crrCol] = '*';
                            crRow = crRow - 1;
                            continue;
                        }

                        if (matrix[crRow - 1, crrCol] == 'c')
                        {
                            coalCount--;

                            matrix[crRow - 1, crrCol] = 's';
                            matrix[crRow, crrCol] = '*';
                            crRow = crRow - 1;

                            if (coalCount == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({crRow}, {crrCol})");
                                return;
                            }

                            continue;

                        }

                        if (matrix[crRow - 1, crrCol] == 'e')
                        {

                            crRow = crRow - 1;
                            Console.WriteLine($"Game over! ({crRow}, {crrCol})");
                            return;
                        }

                    }
                }
                else if (command == "down")
                {
                    if (crRow + 1 < size)
                    {
                        if (matrix[crRow + 1, crrCol] == '*')
                        {
                            matrix[crRow + 1, crrCol] = 's';
                            matrix[crRow, crrCol] = '*';
                            crRow = crRow + 1;
                            continue;
                        }

                        if (matrix[crRow + 1, crrCol] == 'c')
                        {
                            coalCount--;

                            matrix[crRow + 1, crrCol] = 's';
                            matrix[crRow, crrCol] = '*';
                            crRow = crRow + 1;

                            if (coalCount == 0)
                            {
                                Console.WriteLine($"You collected all coals! ({crRow}, {crrCol})");
                                return;
                            }

                            continue;

                        }

                        if (matrix[crRow + 1, crrCol] == 'e')
                        {

                            crRow = crRow + 1;
                            Console.WriteLine($"Game over! ({crRow}, {crrCol})");
                            return;
                        }

                    }
                }


            }

            Console.WriteLine($"{coalCount} coals left. ({crRow}, {crrCol})");

        }
    }
}
