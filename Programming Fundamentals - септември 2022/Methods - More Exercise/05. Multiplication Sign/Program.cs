using System;

namespace _05._Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            negativePozitiveOrZero(firstNum, secondNum, thirdNum);


        }

        private static void negativePozitiveOrZero(int firstNum, int secondNum, int thirdNum)
        {
            string result = String.Empty;

            if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
            {
                result = "zero";

            }

            else if (firstNum < 0 && secondNum < 0 && thirdNum < 0)
            {
                result = "negative";
            }
            else if (firstNum < 0 && secondNum > 0 && thirdNum > 0)
            {
                result = "negative";
            }
            else if (firstNum > 0 && secondNum < 0 && thirdNum > 0)
            {
                result = "negative";
            }
            else if (firstNum < 0 && secondNum > 0 && thirdNum > 0)
            {
                result = "negative";
            }
            else if(firstNum > 0 && secondNum > 0 && thirdNum < 0)
            {
                result = "negative";
            }
            else if (firstNum > 0 && secondNum > 0 && thirdNum > 0)
            {
                result = "positive";
            }
            else if (firstNum < 0 && secondNum < 0 && thirdNum > 0)
            {
                result = "positive";
            }
            else if (firstNum < 0 && secondNum > 0 && thirdNum < 0)
            {
                result = "positive";
            }
            else if (firstNum > 0 && secondNum < 0 && thirdNum < 0)
            {
                result = "positive";
            }
            
            Console.WriteLine(result);
        }
    }
}
