using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] crrRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = crrRow;
            }


            for (int row = 0; row < rows - 1; row++)
            {
                if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] *= 2;
                        jaggedArray[row + 1][i] *= 2;
                    }
                }
                else
                {
                    for (int i = 0; i < jaggedArray[row].Length; i++)
                    {
                        jaggedArray[row][i] /= 2;
                    }
                    for (int i = 0; i < jaggedArray[row+1].Length; i++)
                    {
                        jaggedArray[row + 1][i] /= 2;
                    }
                }
            }

            string commands;

            while ((commands = Console.ReadLine()) != "End")
            {
                string[] cmdArguments = commands.Split(" ");

                string firstCommand = cmdArguments[0];                

                int row = int.Parse(cmdArguments[1]);
                int col = int.Parse(cmdArguments[2]);
                int value = int.Parse(cmdArguments[3]);

                if (firstCommand == "Add")
                {
                    if (IsValid(jaggedArray, row, col))
                    {
                        jaggedArray[row][col] += value;
                    }
                    

                }
                else if (firstCommand == "Subtract")
                {

                    if (IsValid(jaggedArray, row, col))
                    {
                        jaggedArray[row][col] -= value;
                    }

                }

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }
        }

        static bool IsValid(int[][] jaggedArray, int row, int col)
        {
            return row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length;
        }


    }
}
