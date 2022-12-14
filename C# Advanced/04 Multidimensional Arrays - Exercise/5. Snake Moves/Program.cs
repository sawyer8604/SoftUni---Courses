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

            int CountOfWord = 0;

           
            for (int row = 0; row < rows; row++)
            {
                
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        
                        if(CountOfWord == input.Length)
                        {
                            CountOfWord = 0;
                        }

                        matrix[row, col] = input[CountOfWord];

                        CountOfWord++;
                    }

                }
                else
                {
                    for (int col = cols - 1 ; col >= 0; col--)
                    {
                                                
                        if (CountOfWord == input.Length)
                        {
                            CountOfWord = 0;
                        }

                        matrix[row, col] = input[CountOfWord];

                        CountOfWord++;
                    }
                }

                

            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
