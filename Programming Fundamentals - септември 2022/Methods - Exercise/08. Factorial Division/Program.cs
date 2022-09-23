using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double firstFactorial = getFactorial(firstNum);
            double secondFactorial = getFactorial(secondNum);
            double result = factorialDivide(firstFactorial, secondFactorial);
            Console.WriteLine($"{result:f2}");
        }
              

        private static double getFactorial(double number)
        {
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;

            }
            return result;
        }

        private static double factorialDivide(double firstFactorial, double secondFactorial)
        {
            double result = firstFactorial / secondFactorial;
            return result;
        }
    }
}
