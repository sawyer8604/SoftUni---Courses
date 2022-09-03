using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int maxNum = int.MinValue;
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

                if (currentNumber >= maxNum)
                {
                    maxNum = currentNumber;
                }


            }
            int sumWithoutMaxNumber = sum - maxNum;

            if (sumWithoutMaxNumber == maxNum)
            {
                Console.WriteLine($"Yes\r\nSum = {maxNum}");

            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(sumWithoutMaxNumber - maxNum)}");
            }

        }
    }
}
