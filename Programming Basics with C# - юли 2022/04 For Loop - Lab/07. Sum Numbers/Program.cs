using System;

namespace _07._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                int nuberForsum = int.Parse(Console.ReadLine());
                sum += nuberForsum;
            }
            Console.WriteLine(sum);
        }
    }
}
