using System;
using System.Linq;

namespace _02._Truffle_Hunter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] crrRow = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }

            int blackTrufcount = 0;
            int summerTrufCount = 0;
            int whiteTrugCount = 0;

            int WlidBoardCount = 0;

            string command;

            while ((command = Console.ReadLine()) != "Stop the hunt")
            {
                string[] cmdArguments = command.Split(" ");

                string firstCommand = cmdArguments[0];

                if (firstCommand == "Collect")
                {
                    int collectRow = int.Parse(cmdArguments[1]);
                    int collectcol = int.Parse(cmdArguments[2]);

                    if (collectRow >= 0 && collectRow < size && collectcol >= 0 && collectcol < size)
                    {
                        if (matrix[collectRow, collectcol] == 'B')
                        {
                            blackTrufcount++;
                            matrix[collectRow, collectcol] = '-';
                        }
                        else if (matrix[collectRow, collectcol] == 'S')
                        {
                            summerTrufCount++;
                            matrix[collectRow, collectcol] = '-';
                        }

                        else if (matrix[collectRow, collectcol] == 'W')
                        {
                            whiteTrugCount++;
                            matrix[collectRow, collectcol] = '-';
                        }
                    }
                }
                else if(firstCommand == "Wild_Boar")
                {
                    int boardRow = int.Parse(cmdArguments[1]);
                    int boarCol = int.Parse(cmdArguments[2]);


                    string direction = cmdArguments[3];

                    if(direction == "up")
                    {
                        int crrNum = boardRow;

                        for (int i = boardRow; i >= 0; i-=2)
                        {
                            if (matrix[i, boarCol] == 'B')
                            {
                                WlidBoardCount++;
                                matrix[i, boarCol] = '-';
                            }
                            else if (matrix[i, boarCol] == 'S')
                            {
                                WlidBoardCount++;
                                matrix[i, boarCol] = '-';
                            }

                            else if (matrix[i, boarCol] == 'W')
                            {
                                WlidBoardCount++;
                                matrix[i, boarCol] = '-';
                            }
                        }

                    }
                    else if(direction == "down")
                    {
                        int crrNum = boardRow;

                        for (int i = boardRow; i< size; i += 2)
                        {
                            if (matrix[i, boarCol] == 'B')
                            {
                                WlidBoardCount++;
                                matrix[i, boarCol] = '-';
                            }
                            else if (matrix[i, boarCol] == 'S')
                            {
                                WlidBoardCount++;
                                matrix[i, boarCol] = '-';
                            }

                            else if (matrix[i, boarCol] == 'W')
                            {
                                WlidBoardCount++;
                                matrix[i, boarCol] = '-';
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        int crrNum = boarCol;

                        for (int i = boarCol; i >= 0; i -= 2)
                        {
                            if (matrix[boardRow, i] == 'B')
                            {
                                WlidBoardCount++;
                                matrix[boardRow, i] = '-';
                            }
                            else if (matrix[boardRow, i] == 'S')
                            {
                                WlidBoardCount++;
                                matrix[boardRow, i] = '-';
                            }

                            else if (matrix[boardRow, i] == 'W')
                            {
                                WlidBoardCount++;
                                matrix[boardRow, i] = '-';
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        int crrNum = boarCol;

                        for (int i = boarCol; i < size; i += 2)
                        {
                            if (matrix[boardRow, i] == 'B')
                            {
                                WlidBoardCount++;
                                matrix[boardRow, i] = '-';
                            }
                            else if (matrix[boardRow, i] == 'S')
                            {
                                WlidBoardCount++;
                                matrix[boardRow, i] = '-';
                            }

                            else if (matrix[boardRow, i] == 'W')
                            {
                                WlidBoardCount++;
                                matrix[boardRow, i] = '-';
                            }
                        }
                    }
                }

            }

            Console.WriteLine($"Peter manages to harvest {blackTrufcount} black, {summerTrufCount} summer, and {whiteTrugCount} white truffles.");

            Console.WriteLine($"The wild boar has eaten {WlidBoardCount} truffles.");

            Print(matrix);
        }

        static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
