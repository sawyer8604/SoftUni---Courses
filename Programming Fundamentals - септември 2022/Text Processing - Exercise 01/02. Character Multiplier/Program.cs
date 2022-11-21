using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            string firstCommand = input[0];
            string secondCommand = input[1];

            double sum = 0;

            int minLenght = Math.Min(firstCommand.Length, secondCommand.Length);

            sum = GetSum(firstCommand, secondCommand, sum, minLenght);
        }

        private static double GetSum(string firstCommand, string secondCommand, double sum, int minLenght)
        {
            for (int i = 0; i < minLenght; i++)
            {
                sum += firstCommand[i] * secondCommand[i];
            }

            string longerCommand = firstCommand;

            if (secondCommand.Length > firstCommand.Length)
            {
                longerCommand = secondCommand;
            }

            for (int i = minLenght; i < longerCommand.Length; i++)
            {
                sum += longerCommand[i];
            }

            Console.WriteLine(sum);
            return sum;
        }
    }
}
