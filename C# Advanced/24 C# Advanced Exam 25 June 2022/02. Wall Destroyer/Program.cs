using System;

namespace _02._Wall_Destroyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int vankoRow = 0;
            int vankoCol = 0;

            for (int row = 0; row < size; row++)
            {
                string crrRow = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = crrRow[col];

                    if (matrix[row, col] == 'V')
                    {
                        vankoRow = row;
                        vankoCol = col;

                    }
                }
            }

            matrix[vankoRow, vankoCol] = '*';
            int numberOfHoles = 1;
            int countOfRods = 0;

            bool isMoved = false;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                switch (command)
                {
                    case "left":

                        if (vankoCol - 1 >= 0)
                        {
                            if (matrix[vankoRow, vankoCol - 1] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                countOfRods++;
                            }
                            else
                            {

                                matrix[vankoRow, vankoCol] = '*';

                                vankoCol -= 1;
                                isMoved = true;
                                numberOfHoles++;
                            }

                        }

                        break;

                    case "right":

                        if (vankoCol + 1 < matrix.GetLength(0))
                        {
                            if (matrix[vankoRow, vankoCol +1] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                countOfRods++;
                            }
                            else
                            {

                                matrix[vankoRow, vankoCol] = '*';
                                vankoCol += 1;
                                isMoved = true;
                                numberOfHoles++;
                            }
                        }

                        break;

                    case "up":

                        if (vankoRow - 1 >= 0)
                        {
                            if (matrix[vankoRow - 1, vankoCol] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                countOfRods++;
                            }
                            else
                            {
                                matrix[vankoRow, vankoCol] = '*';

                                vankoRow -= 1;
                                isMoved = true;
                                numberOfHoles++;
                            }
                        }

                        break;

                    case "down":

                        if (vankoRow + 1 < matrix.GetLength(0))
                        {
                            if (matrix[vankoRow + 1, vankoCol] == 'R')
                            {
                                Console.WriteLine("Vanko hit a rod!");
                                countOfRods++;
                            }
                            else
                            {
                                matrix[vankoRow, vankoCol] = '*';
                                vankoRow += 1;
                                isMoved = true;
                                numberOfHoles++;
                            }
                        }

                        break;

                }

                if(matrix[vankoRow, vankoCol] == 'C')
                {
                    Console.WriteLine($"Vanko got electrocuted, but he managed to make {numberOfHoles} hole(s).");
                    matrix[vankoRow, vankoCol] = 'E';
                    Print(matrix);
                    return;
                }
                if (matrix[vankoRow, vankoCol] == '*' && isMoved == true)
                {
                    Console.WriteLine($"The wall is already destroyed at position [{vankoRow}, {vankoCol}]!");
                    numberOfHoles--;
                }


            }
            matrix[vankoRow, vankoCol] = 'V';
            
            Console.WriteLine($"Vanko managed to make {numberOfHoles} hole(s) and he hit only {countOfRods} rod(s).");
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
