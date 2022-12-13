using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int equalsSquare = 0;


            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char firstChar = matrix[row, col];
                    char secondChar = matrix[row, col + 1];
                    char thirdChar = matrix[row + 1, col];
                    char fourthChar = matrix[row + 1, col + 1];

                    if (firstChar == secondChar
                        && firstChar == thirdChar
                        && firstChar == fourthChar)
                    {
                        equalsSquare++;
                    }
                }
            }


            Console.WriteLine(equalsSquare);
        }
    }
}
