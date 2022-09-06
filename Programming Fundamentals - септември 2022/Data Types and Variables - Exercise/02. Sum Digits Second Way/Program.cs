using System;

namespace _02._Sum_Digits_Second_Way
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sumOfAllDigits = 0;

            while (number != 0)
            {
                int currentNum = number % 10;
                sumOfAllDigits += currentNum;
                number /= 10;

            }
            Console.WriteLine(sumOfAllDigits);
        }
    }
}
