using System;
using System.Linq;

namespace _01._Array_Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                        
            getMin(numbers);
            int maxNum = arrMaxNum(numbers);
            Console.WriteLine($"Max = {maxNum}");
            int sum = numbers.Sum();
            Console.WriteLine($"Sum = {sum}");

            getAvarage(numbers);
        }

             

        private static void getMin(int[] numbers)
        {
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minValue)
                {
                    minValue = numbers[i];
                }
                
            }
            Console.WriteLine($"Min = {minValue}");
        }

        private static int arrMaxNum(int[] numbers)
        {

            int maxValue = int.MinValue;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxValue)
                {
                    maxValue = numbers[i];
                }

            }
            return maxValue;
        }
        private static void getAvarage(int[] numbers)
        {
            double avarage = (double)numbers.Sum() / numbers.Length;
            Console.WriteLine($"Average = {avarage}");
        }
    }
}
