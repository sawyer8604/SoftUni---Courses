using System;

namespace _03._Recursive_Fibonacci
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
                Console.WriteLine("1");
                return;
            }

            int[] fibonchiArr = new int[numberOfLines];
            fibonchiArr[0] = 1;
            fibonchiArr[1] = 1;

           

            
            int sumOfFibonachiNumbers = 0;

            for (int i = 2; i < numberOfLines; i++)
            {
                fibonchiArr[i] = fibonchiArr[i-2] + fibonchiArr[i-1];
                sumOfFibonachiNumbers = fibonchiArr[i];
            }

            Console.WriteLine(sumOfFibonachiNumbers);
        }
    }
}
