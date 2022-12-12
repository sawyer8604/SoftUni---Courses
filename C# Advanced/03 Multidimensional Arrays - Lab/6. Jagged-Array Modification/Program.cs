using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[numberOfRows][];

            for (int row = 0; row < numberOfRows; row++)
            {

                int[] colums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                jaggedArray[row] = colums;
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArguments = command.Split(" ");

                string firstCommand = cmdArguments[0];

                int row = int.Parse(cmdArguments[1]);
                int col = int.Parse(cmdArguments[2]);
                int value = int.Parse(cmdArguments[3]);

                if(row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                {
                    if(firstCommand == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if(firstCommand == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                   
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            foreach (var array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }

            //for (int row = 0; row < jaggedArray.Length; row++)
            //{
            //    for (int col = 0; col < jaggedArray[row].Length; col++)
            //    {
            //        Console.Write($"{jaggedArray[row][col]} ");
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
