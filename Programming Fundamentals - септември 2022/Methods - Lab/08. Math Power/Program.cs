using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            double result = Math_Power(firstNum, secondNum);
            Console.WriteLine(result);            
        }

        static double Math_Power(double firstNum, int secondNum)
        {
            double result = 1;
            for (int i = 0; i < secondNum; i++)
            {
                result *= firstNum;


            }
            return result;
        }
    }
}
