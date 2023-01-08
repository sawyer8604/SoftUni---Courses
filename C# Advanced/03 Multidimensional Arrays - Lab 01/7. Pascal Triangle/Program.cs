using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[numberOfRows][];
                       

            for (int row = 0; row < numberOfRows; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                long[] crrRow = new long[row + 1];

                crrRow[0] = 1;
                crrRow[row] = 1;
                pascalTriangle[row] = crrRow;

                for (int col = 1; col < pascalTriangle[row].Length - 1; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col - 1] + pascalTriangle[row - 1][col];
                }

                
            }

            for (int row = 0; row < numberOfRows; row++)
            {
                for (int col = 0; col < pascalTriangle[row].Length; col++)
                {
                    Console.Write($"{pascalTriangle[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
