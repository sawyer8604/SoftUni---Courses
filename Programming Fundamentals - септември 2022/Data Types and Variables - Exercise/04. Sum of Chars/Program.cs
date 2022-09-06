using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfDigit = 0;

            for (int i = 1; i <= number; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                sumOfDigit += (int)digit;

            }
            Console.WriteLine($"The sum equals: {sumOfDigit}");
        }
    }
}
