using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int sumOdd = 0;
            int sumEven = 0;
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] %2 == 0)
                {
                    sumOdd+= number[i];
                }
                else
                {
                    sumEven += number[i];
                }
            }
            result = sumOdd - sumEven;
            Console.WriteLine(result);


        }

    }
}
