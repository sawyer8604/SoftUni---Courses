using System;
using System.Linq;

namespace _4._Symbol_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRowAndColums = int.Parse(Console.ReadLine());

            char[,] matrix = new char[numberOfRowAndColums, numberOfRowAndColums];

            for (int row = 0; row < numberOfRowAndColums; row++)
            {
                string input = Console.ReadLine();
                char[] chars = input.ToCharArray();

                for (int col = 0; col < numberOfRowAndColums; col++)
                {
                    matrix[row, col] = chars[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < numberOfRowAndColums; row++)
            {
                for (int col = 0; col < numberOfRowAndColums; col++)
                {
                    if(symbol== matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");

        }
    }
}
