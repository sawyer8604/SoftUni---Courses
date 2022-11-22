using System;
using System.Linq;
using System.Numerics;

namespace _01._Convert_from_base_10_to_base_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] numbers = Console.ReadLine().Split(" ").Select(BigInteger.Parse).ToArray();

            int baseN = (int)numbers[0];
            BigInteger number = numbers[1];
            BigInteger remainder;

            string result = null;

            if (baseN >= 2 && baseN <= 10)
            {
                while (number > 0)
                {
                    remainder = number % baseN;
                    number /= baseN;

                    result = remainder.ToString() + result;
                }

                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
