using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = size[0];
            int colums = size[1];

            int[,] matrix = new int[rows, colums];


            for (int row = 0; row < rows; row++)
            {
                int[] numbersInMatrix = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < colums; col++)
                {
                    matrix[row, col] = numbersInMatrix[col];
                }
            }

           

            for (int col = 0; col < colums; col++)
            {
                int sum = 0;

                for (int row = 0; row < rows; row++)
                {
                    sum += matrix[row, col];
                }

                Console.WriteLine(sum);
            }

            
        }
    }
}
