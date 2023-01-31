using System;

namespace _02._Navy_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfField, sizeOfField];

            int subMarineRow = 0;
            int submarineCol = 0;

            for (int row = 0; row < sizeOfField; row++)
            {
                string crrRow = Console.ReadLine();

                for (int col = 0; col < sizeOfField; col++)
                {
                    matrix[row, col] = crrRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        subMarineRow = row;
                        submarineCol = col;
                    }
                }
            }

            int mineCounter = 0;
            int shipCounter = 3;

            while (true)
            {
                string command = Console.ReadLine();

                switch (command)
                {
                    case "left":

                        if(submarineCol - 1 >= 0)
                        {
                            matrix[subMarineRow, submarineCol] = '-';
                            submarineCol -=1;
                            
                        }

                        break;

                    case "right":

                        if (submarineCol + 1 < matrix.GetLength(0))
                        {
                            matrix[subMarineRow, submarineCol] = '-';
                            submarineCol += 1;
                            
                        }

                        break;

                    case "up":

                        if(subMarineRow -1 >= 0)
                        {
                            matrix[subMarineRow, submarineCol] = '-';
                            subMarineRow -=1;
                            
                        }

                        break;

                    case "down":

                        if (subMarineRow + 1 < matrix.GetLength(0))
                        {
                            matrix[subMarineRow, submarineCol] = '-';
                            subMarineRow += 1;
                            
                        }

                        break;

                }

                if (matrix[subMarineRow, submarineCol] == '*')
                {
                    mineCounter ++;
                    matrix[subMarineRow, submarineCol] = 'S';

                    if (mineCounter == 3)
                    {
                        Console.WriteLine($"Mission failed, U-9 disappeared! Last known coordinates [{subMarineRow}, {submarineCol}]!");
                        Print(matrix);
                        return;
                    }
                }


                if(matrix[subMarineRow, submarineCol] == 'C')
                {
                    shipCounter--;
                    matrix[subMarineRow, submarineCol] = 'S';

                    if (shipCounter == 0)
                    {
                        Console.WriteLine($"Mission accomplished, U-9 has destroyed all battle cruisers of the enemy!");

                        Print(matrix);
                        return;
                    }
                }


            }

            static void Print(char[,] matrix)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row,col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
