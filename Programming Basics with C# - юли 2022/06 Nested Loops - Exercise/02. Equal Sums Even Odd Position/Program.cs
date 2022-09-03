using System;

namespace _02._Equal_Sums_Even_Odd_Position_SecondWay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= endNum; i++)
            {
                string number = i.ToString();
                int evenSum = 0;
                int oddSum = 0;

                for (int j = 0; j < number.Length; j++)
                {
                    int currentDigit = int.Parse(number[j].ToString());

                    if (j % 2 == 0)
                    {
                        evenSum += currentDigit;

                    }
                    else
                    {
                        oddSum += currentDigit;

                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }

            }

        }

    }
}
