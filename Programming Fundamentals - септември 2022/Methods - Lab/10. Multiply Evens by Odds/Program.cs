using System;
using System.Security;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));


            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);          
             
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(result);
        }

        

        private static int GetSumOfOddDigits(int number)
        {
            int currentNum = number;
            
            int oddSum = 0;

            while (number > 0)
            {
                currentNum = number % 10;
                if (currentNum % 2 != 0)
                {
                    oddSum += currentNum;
                }
                number /= 10;

            }
            return oddSum;

        }

        private static int  GetSumOfEvenDigits(int number)
        {
            int currentNum = number;
            int evenSum = 0;

            while (number > 0)
            {
                currentNum = number % 10;
                if (currentNum % 2 == 0)
                {
                    evenSum+=currentNum;
                }
                number /= 10;

            }
            return evenSum;
        }

        private static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
