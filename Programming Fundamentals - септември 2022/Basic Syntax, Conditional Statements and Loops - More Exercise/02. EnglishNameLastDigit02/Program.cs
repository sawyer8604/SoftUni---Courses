using System;

namespace _02._EnglishNameLastDigit02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // With ternaty operator

            int number = int.Parse(Console.ReadLine());

            int lastDigit = number % 10;


            string lastDigitName = lastDigit == 0 ? "zero" :
                lastDigit == 1 ? "one" :
                lastDigit == 2 ? "two" :
                lastDigit == 3 ? "three" :
                lastDigit == 4 ? "four" :
                lastDigit == 5 ? "five" :
                lastDigit == 6 ? "six" :
                lastDigit == 7 ? "seven" :
                lastDigit == 8 ? "eight" :
                lastDigit == 9 ? "nine" : "";
            Console.WriteLine(lastDigitName);
        }
    }
}
