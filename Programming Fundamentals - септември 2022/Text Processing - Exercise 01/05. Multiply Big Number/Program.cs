using System;
using System.Collections.Generic;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();

            int secondNum = int.Parse(Console.ReadLine());

            List<string> result = new List<string>();

            int sum = 0;
            int remainder = 0;

            if(secondNum == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                string firstChar = firstNum[i].ToString();

                int num = int.Parse(firstChar);

                sum = num * secondNum + remainder;

                int currentNum = sum % 10;
                remainder = sum / 10;

                string currDigit = currentNum.ToString();

                result.Insert(0, currDigit);

            }
            if(remainder > 0)
            {
                string lastDigit = remainder.ToString();
                result.Insert(0, lastDigit);

            }

            Console.WriteLine(string.Join("", result));

        }
    }
}
