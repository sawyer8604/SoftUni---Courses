using System;
using System.Linq;

namespace _7._Knight_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string crrRow = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = crrRow[col];
                }
            }

            int maxAttachk = 0;

            int allKnightToRemove = 0;


            while (true)
            {
                maxAttachk = 0;
                int crrRow = 0;
                int crrCol = 0;
                bool isKnight = false;


                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {

                            int crrAttack = 0;

                            //up - left

                            if (row - 2 >= 0 && col - 1 >= 0 && matrix[row - 2, col - 1] == 'K')
                            {
                                crrAttack++;
                            }

                            // left - up

                            if (row - 1 >= 0 && col - 2 >= 0 && matrix[row - 1, col - 2] == 'K')
                            {
                                crrAttack++;
                            }

                            // left - down
                            if (row + 1 < size && col - 2 >= 0 && matrix[row + 1, col - 2] == 'K')
                            {
                                crrAttack++;
                            }

                            // down left
                                                        
                            if (row + 2 < size && col - 1 >= 0 && matrix[row + 2, col - 1] == 'K')
                            {
                                crrAttack++;
                            }


                            // up - right

                            if (row - 2 >= 0 && col + 1 < size && matrix[row - 2, col +1 ] =='K')
                            {
                                crrAttack++;
                            }

                            // right up 

                            if (row - 1 >= 0 && col + 2 < size && matrix[row - 1, col + 2] == 'K')
                            {
                                crrAttack++;
                            }

                            // right - down

                            if (row + 1 < size && col + 2 < size && matrix[row + 1, col + 2] == 'K')
                            {
                                crrAttack++;
                            }

                            // down - right

                            if (row + 2 < size && col + 1 < size && matrix[row + 2, col + 1] == 'K')
                            {
                                crrAttack++;
                            }

                            if(crrAttack > maxAttachk)
                            {
                                maxAttachk= crrAttack;
                                crrRow = row;
                                crrCol = col;                                
                                isKnight = true;
                            }



                        }


                    }


                }

                if(isKnight)
                {
                    matrix[crrRow, crrCol] = '0';
                    allKnightToRemove++;
                }

                if(maxAttachk == 0)
                {
                    break;
                }
                

            }

            Console.WriteLine(allKnightToRemove);

            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write($"{matrix[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
