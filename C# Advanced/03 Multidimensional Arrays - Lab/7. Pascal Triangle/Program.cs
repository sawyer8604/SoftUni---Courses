using System;

namespace _7._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRow = int.Parse(Console.ReadLine());
            
            long[][] pascal = new long[numberOfRow][];

            for (int row = 0; row < numberOfRow; row++)
            {
                long[] crrRow = new long[row +1];
                crrRow[0] = 1;
                crrRow[row] = 1;

                for (int col = 1; col < row; col++)
                {
                    crrRow[col] = pascal[row - 1][col] + pascal[row - 1][col -1];

                }
                pascal[row] = crrRow;
            }


            foreach (var array in pascal)
            {
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
