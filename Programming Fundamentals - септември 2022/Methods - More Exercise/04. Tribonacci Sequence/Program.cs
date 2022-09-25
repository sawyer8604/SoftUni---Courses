using System;

namespace _04._Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            if (numberOfLines == 0)
            {
                Console.WriteLine("0");
                return;
            }
            else if (numberOfLines == 1)
            {
                Console.WriteLine("1");
                return;
            }
            else if (numberOfLines == 2)
            {
                Console.WriteLine("1 1");
                return;
            }


            getTrubonachiNum(numberOfLines);
            
        }

        private static void getTrubonachiNum(int numberOfLines)
        {
            int[] fibonchiArr = new int[numberOfLines];
            fibonchiArr[0] = 1;
            fibonchiArr[1] = 1;
            fibonchiArr[2] = 2;


            Console.Write("1 ");
            Console.Write("1 ");
            Console.Write("2 ");

            int sumOfFibonachiNumbers = 0;

            for (int i = 3; i < numberOfLines; i++)
            {
                fibonchiArr[i] = fibonchiArr[i - 3] + fibonchiArr[i - 2] + fibonchiArr[i - 1];
                sumOfFibonachiNumbers = fibonchiArr[i];

                Console.Write($"{sumOfFibonachiNumbers} ");
            }

            

        }
    }
}
