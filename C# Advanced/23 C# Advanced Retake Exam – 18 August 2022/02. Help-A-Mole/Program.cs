using System;

namespace _02._Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sizeOfField = int.Parse(Console.ReadLine());

            char[,] matrix = new char[sizeOfField, sizeOfField];

            int molRow = 0;
            int molCol = 0;

            for (int row = 0; row < sizeOfField; row++)
            {
                string crrRow = Console.ReadLine();

                for (int col = 0; col < sizeOfField; col++)
                {
                    matrix[row, col] = crrRow[col];

                    if (matrix[row, col] == 'M')
                    {
                        molRow = row;
                        molCol = col;
                        
                    }
                }
            }
            matrix[molRow, molCol] = '-';
            int points = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if(command == "End")
                {
                    break;
                }

                switch (command)
                {
                    case "left":

                        if (molCol - 1 >= 0)
                        {
                            molCol -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }

                        break;

                    case "right":

                        if (molCol + 1 < matrix.GetLength(0))
                        {                            
                            molCol += 1;
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }

                        break;

                    case "up":

                        if (molRow - 1 >= 0)
                        {                            
                            molRow -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }

                        break;

                    case "down":

                        if (molRow + 1 < matrix.GetLength(0))
                        {                           
                            molRow += 1;
                        }
                        else
                        {
                            Console.WriteLine("Don't try to escape the playing field!");
                        }
                        break;
                        
                }


                if (matrix[molRow, molCol] == 'S')
                {
                    points -= 3;

                    matrix[molRow, molCol] = '-';

                    for (int row = 0; row < sizeOfField; row++)
                    {

                        for (int col = 0; col < sizeOfField; col++)
                        {
                            if (matrix[row, col] == 'S')
                            {
                                molRow = row;
                                molCol = col;
                            }

                        }
                    }

                    matrix[molRow, molCol] = '-';
                }

                if(matrix[molRow, molCol] != '-' && matrix[molRow, molCol] != 'S')
                {
                    string crrChar = matrix[molRow, molCol].ToString();

                    points += int.Parse(crrChar);
                     
                    matrix[molRow, molCol] = '-';
                    if (points >= 25)
                    {
                        matrix[molRow, molCol] = 'M';
                        Console.WriteLine("Yay! The Mole survived another game!");
                        Console.WriteLine($"The Mole managed to survive with a total of {points} points.");
                        Print(matrix);
                        return;
                    }
                }
            }

            Console.WriteLine("Too bad! The Mole lost this battle!");
            Console.WriteLine($"The Mole lost the game with a total of {points} points.");
            matrix[molRow, molCol] = 'M';
            Print(matrix);
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
