using System;
using System.Linq;

namespace _5._Snake_Moves
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

            char[,] matrix = new char[rows, cols];

            string input = Console.ReadLine();

            int index = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = input[index];

                        index++;
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                    }
                }

                if (row % 2 != 0)
                {
                    for (int i = cols - 1; i >= 0; i--)
                    {
                        matrix[row, i] = input[index];

                        index++;
                        if (index == input.Length)
                        {
                            index = 0;
                        }
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
