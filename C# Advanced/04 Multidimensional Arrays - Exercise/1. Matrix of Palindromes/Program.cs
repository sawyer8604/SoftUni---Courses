using System;
using System.Linq;

namespace _1._Matrix_of_Palindromes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = size[0];
            int cols = size[1];

            string[,] matrix = new string[rows, cols];


            for (int row = 0; row < rows; row++)
            {
                char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] += alphabet[row];
                    matrix[row, col] += alphabet[col +row];
                    matrix[row, col] += alphabet[row];
                }

            }

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
