using System;

namespace _2._Sum_Digits_third_way
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputLength = input.Length;
            int sum = 0;

            for (int i = 0; i < inputLength; i++)
            {
                char digit = input[i];
                int currentNum = int.Parse(digit.ToString());
                sum += currentNum;
            }
            Console.WriteLine(sum);

        }
    }
}
