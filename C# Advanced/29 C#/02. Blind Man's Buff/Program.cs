using System;
using System.Drawing;
using System.Linq;

namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfField = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int matrixRow = sizeOfField[0];
            int matrixCol = sizeOfField[1];

            char[,] matrix = new char[matrixRow, matrixCol];

            int subRow = 0;
            int subCol = 0;

            for (int row = 0; row < matrixRow; row++)
            {
                char[] crrRow = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrixCol; col++)
                {
                    matrix[row, col] = crrRow[col];

                    if (matrix[row, col] == 'B')
                    {
                        subRow = row;
                        subCol = col;

                    }

                }
            }

            matrix[subRow, subCol] = '-';

            int countOponent = 0;

            int moves = 0;

            string command;

            while ((command = Console.ReadLine()) != "Finish")
            {
                bool isMove = false;

                switch (command)
                {
                    case "left":

                        if (subCol - 1 >= 0 && matrix[subRow, subCol - 1] != 'O')
                        {
                            subCol -= 1;
                            isMove = true;
                        }


                        break;

                    case "right":

                        if (subCol + 1 < matrix.GetLength(1) && matrix[subRow, subCol + 1] != 'O')
                        {
                            subCol += 1;
                            isMove = true;
                        }


                        break;

                    case "up":

                        if (subRow - 1 >= 0 && matrix[subRow - 1, subCol] != 'O')
                        {
                            subRow -= 1;
                            isMove = true;
                        }


                        break;

                    case "down":

                        if (subRow + 1 < matrix.GetLength(0) && matrix[subRow + 1, subCol] != 'O')
                        {
                            subRow += 1;
                            isMove = true;
                        }

                        break;

                }

                if(matrix[subRow, subCol] == 'P')
                {
                    matrix[subRow, subCol] = '-';
                    countOponent++;
                    moves++;

                    if (countOponent == 3)
                    {
                        Console.WriteLine("Game over!");

                        Console.WriteLine($"Touched opponents: {countOponent} Moves made: {moves}");

                        return;

                    }

                    continue;
                }

                if(isMove == true)
                {
                    if (matrix[subRow, subCol] == '-')
                    {
                        moves++;
                    }
                }
                


            }

            Console.WriteLine("Game over!");

            Console.WriteLine($"Touched opponents: {countOponent} Moves made: {moves}");


           // Print(matrix);


        }

        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
