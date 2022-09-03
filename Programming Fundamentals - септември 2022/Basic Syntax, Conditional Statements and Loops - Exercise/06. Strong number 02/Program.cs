using System;

namespace _06._Strong_number_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;

            int factorialSum = 0;

            while(number > 0)
            {
                int currentNum = number % 10;
                number /=10;

                int factorial = 1;

                for (int i = 1; i <= currentNum; i++)
                {
                    factorial *= i;
                }
                factorialSum+=factorial;


            }
            if (numberCopy == factorialSum)
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
