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

            for (int i = 0; i < rows - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] *= 2;
                        jaggedArray[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jaggedArray[i].Length; j++)
                    {
                        jaggedArray[i][j] /= 2;

                    }

                    for (int j = 0; j < jaggedArray[i + 1].Length; j++)
                    {
                        jaggedArray[i + 1][j] /= 2;
                    }
                }
            }


            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];

                switch (firstCommand)
                {
                    case "Add":
                        {
                            int crrRow = int.Parse(cmdArguments[1]);
                            int crrCol = int.Parse(cmdArguments[2]);
                            int value = int.Parse(cmdArguments[3]);

                            if (IsValid(jaggedArray, crrRow, crrCol))
                            {
                                jaggedArray[crrRow][crrCol] += value;
                            }
                        }
                        break;

                    case "Subtract":
                        {
                            int crrRow = int.Parse(cmdArguments[1]);
                            int crrCol = int.Parse(cmdArguments[2]);
                            int value = int.Parse(cmdArguments[3]);

                            if (IsValid(jaggedArray, crrRow, crrCol))
                            {
                                jaggedArray[crrRow][crrCol] -= value;

                            }
                        }
                        break;

                }

            }

            foreach (var array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }

        static bool IsValid(int[][] jaggedArray, int crrRow, int crrCol)
        {
            return (crrRow >= 0 && crrRow < jaggedArray.Length && crrCol >= 0 && crrCol < jaggedArray[crrRow].Length);
        }
    }
}
