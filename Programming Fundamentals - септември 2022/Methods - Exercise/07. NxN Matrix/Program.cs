using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            nXnMatrix(number);
            
        }

        private static void nXnMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{number} ");

                for (int j = 1; j < number; j++)
                {
                    Console.Write($"{number} ");

                }
                Console.WriteLine();
            }
            

        }
    }
}
