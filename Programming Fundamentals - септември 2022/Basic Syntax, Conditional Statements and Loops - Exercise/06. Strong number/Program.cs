using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int numberLength = number.Length;
            int strongNumber = int.Parse(number);

            int numberCopy = strongNumber;
            int sumFactorial = 0;

            for (int i = 0; i <= numberLength - 1; i++)
            {
                char digit = number[i];

                int currentDigit = (int)digit - 48;

                int currentNum = 1;

                for (int j = 1; j <= currentDigit; j++)
                {
                    currentNum *= j;


                }
                sumFactorial += currentNum;



            }
            if (numberCopy == sumFactorial)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            

            

        }
    }
}
