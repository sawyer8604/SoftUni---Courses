using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightsum = 0;

            for (int i = 0; i < 2 * number; i++) //i < 2*number
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i < number)
                {
                    leftSum += currentNumber;
                }

                else
                {
                    rightsum += currentNumber;
                }
            }

            if (leftSum == rightsum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum - rightsum)}");

            }
        }
    }
}
