using System;

namespace _02._Navy_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfField, sizeOfField];

            int subRow = 0;
            int subCol = 0;

            for (int row = 0; row < sizeOfField; row++)
            {
                string crrRow = Console.ReadLine();

                for (int col = 0; col < sizeOfField; col++)
                {
                    matrix[row, col] = crrRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        subRow = row;
                        subCol = col;

                    }
                }
            }
            matrix[subRow, subCol] = '-';

            int cruiser = 3;
            int mineCounter = 0;

            while (true)
            {
                string command = Console.ReadLine();
                
                switch (command)
                {
                    case "left":

                        if (subCol - 1 >= 0)
                        {
                            subCol -= 1;
                        }
                        

                        break;

                    case "right":

                        if (subCol + 1 < matrix.GetLength(0))
                        {
                            subCol += 1;
                        }
                       

                        break;

                    case "up":

                        if (subRow - 1 >= 0)
                        {
                            subRow -= 1;
                        }
                       
                        break;

                    case "down":

                        if (subRow + 1 < matrix.GetLength(0))
                        {
                            subRow += 1;
                        }                        
                        break;

                }

                if (matrix[subRow, subCol] == '*')
                {
                    mineCounter++;

                    if(mineCounter == 3)
                    {
                        matrix[subRow, subCol] = 'S';
                        Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{subRow}, {subCol}]!");
                        Print(matrix);
                        return;
                    }

                    matrix[subRow, subCol] = '-';
                }

                if (matrix[subRow, subCol] == 'C')
                {
                    cruiser--;

                    if (cruiser == 0)
                    {
                        matrix[subRow, subCol] = 'S';
                        Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");
                        Print(matrix);
                        return;
                    }

                    matrix[subRow, subCol] = '-';
                }

            }
        }

        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
