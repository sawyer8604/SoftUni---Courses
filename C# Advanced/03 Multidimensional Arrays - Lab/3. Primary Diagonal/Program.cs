using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSquareMatrix = int.Parse(Console.ReadLine());

            int[,] squareMAtrix = new int[numberOfSquareMatrix, numberOfSquareMatrix];

            for (int row = 0; row < numberOfSquareMatrix; row++)
            {
                int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int col = 0; col < numberOfSquareMatrix; col++)
                {
                    squareMAtrix[row, col] = number[col];
                }
            }

            int sumOfDiagoal = 0;

            for (int row = 0; row < numberOfSquareMatrix; row++)
            {
               
                for (int col = 0; col < numberOfSquareMatrix; col++)
                {
                    if(row == col)
                    {
                        sumOfDiagoal += squareMAtrix[row, col];
                    }
                    
                }
            }
            Console.WriteLine(sumOfDiagoal);
        }
    }
}
