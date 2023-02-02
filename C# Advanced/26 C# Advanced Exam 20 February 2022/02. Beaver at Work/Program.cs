using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Beaver_at_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            int beaverRow = 0;
            int beaverCol = 0;
            int branchCount = 0;

            for (int row = 0; row < size; row++)
            {
                char[] crrRow = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = crrRow[col];

                    if (matrix[row, col] == 'B')
                    {
                        beaverRow = row;
                        beaverCol = col;
                    }

                    if (char.IsLetter(matrix[row, col]) && char.IsLower(matrix[row, col]))
                    {
                        branchCount++;
                    }
                }
            }

            matrix[beaverRow, beaverCol] = '-';

            List<char> branch = new List<char>();
            bool isMove = false;
            bool isCollect = false;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "left":

                        if (beaverCol - 1 >= 0)
                        {
                            beaverCol -= 1;
                            isMove = true;
                        }
                        else
                        {
                            if (branch.Count > 0)
                            {
                                branch.RemoveAt(branch.Count - 1);
                            }
                        }

                        break;

                    case "right":

                        if (beaverCol + 1 < matrix.GetLength(0))
                        {
                            beaverCol += 1;
                            isMove = true;
                        }
                        else
                        {
                            if (branch.Count > 0)
                            {
                                branch.RemoveAt(branch.Count - 1);
                            }
                        }

                        break;

                    case "up":

                        if (beaverRow - 1 >= 0)
                        {
                            beaverRow -= 1;
                            isMove = true;
                        }
                        else
                        {
                            if (branch.Count > 0)
                            {
                                branch.RemoveAt(branch.Count - 1);
                            }
                        }

                        break;

                    case "down":

                        if (beaverRow + 1 < matrix.GetLength(0))
                        {
                            beaverRow += 1;
                            isMove = true;
                        }
                        else
                        {
                            if (branch.Count > 0)
                            {
                                branch.RemoveAt(branch.Count - 1);
                            }
                        }
                        break;

                }
                if (isMove)
                {


                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                    {
                        branch.Add(matrix[beaverRow, beaverCol]);
                        matrix[beaverRow, beaverCol] = '-';
                        branchCount--;
                        if(branchCount == 0)
                        {
                            isCollect = true;
                            break;
                        }
                    }

                    if (matrix[beaverRow, beaverCol] == 'F')
                    {
                        if (command == "left" && beaverCol != 0)
                        {
                            matrix[beaverRow, beaverCol] = '-';

                            beaverCol = 0;

                            if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                            {
                                branch.Add(matrix[beaverRow, beaverCol]);
                                matrix[beaverRow, beaverCol] = '-';
                                branchCount--;
                                if (branchCount == 0)
                                {
                                    isCollect = true;
                                    break;
                                }
                            }

                            if (matrix[beaverRow, beaverCol] == 'F')
                            {
                                matrix[beaverRow, beaverCol] = '-';

                                beaverCol = size - 1;

                                if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                {
                                    branch.Add(matrix[beaverRow, beaverCol]);
                                    matrix[beaverRow, beaverCol] = '-';
                                    branchCount--;
                                    if (branchCount == 0)
                                    {
                                        isCollect = true;
                                        break;
                                    }
                                }

                                if (matrix[beaverRow, beaverCol] == 'F')
                                {
                                    matrix[beaverRow, beaverCol] = '-';

                                    beaverCol = 0;

                                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                    {
                                        branch.Add(matrix[beaverRow, beaverCol]);
                                        matrix[beaverRow, beaverCol] = '-';
                                        branchCount--;
                                        if (branchCount == 0)
                                        {
                                            isCollect = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (command == "left" && beaverCol == 0)
                            {
                                matrix[beaverRow, beaverCol] = '-';
                                beaverCol = size - 1;

                                if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                {
                                    branch.Add(matrix[beaverRow, beaverCol]);
                                    matrix[beaverRow, beaverCol] = '-';
                                    branchCount--;
                                    if (branchCount == 0)
                                    {
                                        isCollect = true;
                                        break;
                                    }
                                }

                                if (matrix[beaverRow, beaverCol] == 'F')
                                {
                                    matrix[beaverRow, beaverCol] = '-';
                                    beaverCol = 0;

                                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                    {
                                        branch.Add(matrix[beaverRow, beaverCol]);
                                        matrix[beaverRow, beaverCol] = '-';
                                        branchCount--;
                                        if (branchCount == 0)
                                        {
                                            isCollect = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (matrix[beaverRow, beaverCol] == 'F')
                    {
                        if (command == "right" && beaverCol != size - 1)
                        {
                            matrix[beaverRow, beaverCol] = '-';

                            beaverCol = size - 1;

                            if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                            {
                                branch.Add(matrix[beaverRow, beaverCol]);
                                matrix[beaverRow, beaverCol] = '-';
                                branchCount--;
                                if (branchCount == 0)
                                {
                                    isCollect = true;
                                    break;
                                }
                            }

                            if (matrix[beaverRow, beaverCol] == 'F')
                            {
                                matrix[beaverRow, beaverCol] = '-';

                                beaverCol = 0;

                                if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                {
                                    branch.Add(matrix[beaverRow, beaverCol]);
                                    matrix[beaverRow, beaverCol] = '-';
                                    branchCount--;
                                    if (branchCount == 0)
                                    {
                                        isCollect = true;
                                        break;
                                    }
                                }

                                if (matrix[beaverRow, beaverCol] == 'F')
                                {
                                    matrix[beaverRow, beaverCol] = '-';

                                    beaverCol = size - 1;

                                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                    {
                                        branch.Add(matrix[beaverRow, beaverCol]);
                                        matrix[beaverRow, beaverCol] = '-';
                                        branchCount--;
                                        if (branchCount == 0)
                                        {
                                            isCollect = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (command == "right" && beaverCol == size - 1)
                            {
                                matrix[beaverRow, beaverCol] = '-';

                                beaverCol = 0;

                                if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                {
                                    branch.Add(matrix[beaverRow, beaverCol]);
                                    matrix[beaverRow, beaverCol] = '-';
                                    branchCount--;
                                    if (branchCount == 0)
                                    {
                                        isCollect = true;
                                        break;
                                    }
                                }

                                if (matrix[beaverRow, beaverCol] == 'F')
                                {
                                    matrix[beaverRow, beaverCol] = '-';

                                    beaverCol = size - 1;

                                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                    {
                                        branch.Add(matrix[beaverRow, beaverCol]);
                                        matrix[beaverRow, beaverCol] = '-';
                                        branchCount--;
                                        if (branchCount == 0)
                                        {
                                            isCollect = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (matrix[beaverRow, beaverCol] == 'F')
                    {
                        if (command == "down" && beaverRow != size - 1)
                        {
                            matrix[beaverRow, beaverCol] = '-';

                            beaverRow = size - 1;

                            if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                            {
                                branch.Add(matrix[beaverRow, beaverCol]);
                                matrix[beaverRow, beaverCol] = '-';
                                branchCount--;
                                if (branchCount == 0)
                                {
                                    isCollect = true;
                                    break;
                                }
                            }

                            if (matrix[beaverRow, beaverCol] == 'F')
                            {
                                matrix[beaverRow, beaverCol] = '-';

                                beaverRow = 0;

                                if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                {
                                    branch.Add(matrix[beaverRow, beaverCol]);
                                    matrix[beaverRow, beaverCol] = '-';
                                    branchCount--;
                                    if (branchCount == 0)
                                    {
                                        isCollect = true;
                                        break;
                                    }
                                }

                                if (matrix[beaverRow, beaverCol] == 'F')
                                {
                                    matrix[beaverRow, beaverCol] = '-';

                                    beaverRow = size - 1;

                                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                    {
                                        branch.Add(matrix[beaverRow, beaverCol]);
                                        matrix[beaverRow, beaverCol] = '-';
                                        branchCount--;
                                        if (branchCount == 0)
                                        {
                                            isCollect = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (command == "down" && beaverRow == size - 1)
                            {
                                matrix[beaverRow, beaverCol] = '-';

                                beaverRow = 0;

                                if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                {
                                    branch.Add(matrix[beaverRow, beaverCol]);
                                    matrix[beaverRow, beaverCol] = '-';
                                    branchCount--;
                                    if (branchCount == 0)
                                    {
                                        isCollect = true;
                                        break;
                                    }
                                }

                                if (matrix[beaverRow, beaverCol] == 'F')
                                {
                                    matrix[beaverRow, beaverCol] = '-';

                                    beaverCol = size - 1;

                                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                    {
                                        branch.Add(matrix[beaverRow, beaverCol]);
                                        matrix[beaverRow, beaverCol] = '-';
                                        branchCount--;
                                        if (branchCount == 0)
                                        {
                                            isCollect = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }

                    if (matrix[beaverRow, beaverCol] == 'F')
                    {
                        if (command == "up" && beaverRow != 0)
                        {
                            matrix[beaverRow, beaverCol] = '-';

                            beaverRow = 0;

                            if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                            {
                                branch.Add(matrix[beaverRow, beaverCol]);
                                matrix[beaverRow, beaverCol] = '-';
                                branchCount--;
                                if (branchCount == 0)
                                {
                                    isCollect = true;
                                    break;
                                }
                            }

                            if (matrix[beaverRow, beaverCol] == 'F')
                            {
                                matrix[beaverRow, beaverCol] = '-';

                                beaverRow = size - 1;

                                if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                {
                                    branch.Add(matrix[beaverRow, beaverCol]);
                                    matrix[beaverRow, beaverCol] = '-';
                                    branchCount--;
                                    if (branchCount == 0)
                                    {
                                        isCollect = true;
                                        break;
                                    }
                                }

                                if (matrix[beaverRow, beaverCol] == 'F')
                                {
                                    matrix[beaverRow, beaverCol] = '-';

                                    beaverRow = 0;

                                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                    {
                                        branch.Add(matrix[beaverRow, beaverCol]);
                                        matrix[beaverRow, beaverCol] = '-';
                                        branchCount--;
                                        if (branchCount == 0)
                                        {
                                            isCollect = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (command == "up" && beaverRow == 0)
                            {
                                matrix[beaverRow, beaverCol] = '-';

                                beaverRow = size - 1;

                                if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                {
                                    branch.Add(matrix[beaverRow, beaverCol]);
                                    matrix[beaverRow, beaverCol] = '-';
                                    branchCount--;
                                    if (branchCount == 0)
                                    {
                                        isCollect = true;
                                        break;
                                    }
                                }

                                if (matrix[beaverRow, beaverCol] == 'F')
                                {
                                    matrix[beaverRow, beaverCol] = '-';

                                    beaverCol = 0;

                                    if (char.IsLetter(matrix[beaverRow, beaverCol]) && char.IsLower(matrix[beaverRow, beaverCol]))
                                    {
                                        branch.Add(matrix[beaverRow, beaverCol]);
                                        matrix[beaverRow, beaverCol] = '-';
                                        branchCount--;
                                        if (branchCount == 0)
                                        {
                                            isCollect = true;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    
                }
                matrix[beaverRow, beaverCol] = 'B';
               
                matrix[beaverRow, beaverCol] = '-';
            }
            matrix[beaverRow, beaverCol] = 'B';

            if(isCollect)
            {
                Console.WriteLine($"The Beaver successfully collect {branch.Count} wood branches: {string.Join(", ", branch)}.");
            }
            else
            {
                Console.WriteLine($"The Beaver failed to collect every wood branch. There are {branchCount} branches left.");
            }
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
