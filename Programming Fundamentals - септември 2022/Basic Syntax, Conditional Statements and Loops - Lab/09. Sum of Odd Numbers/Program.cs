using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfOddNumbers = int.Parse(Console.ReadLine());
            var oddNubers = 1;
            var sumOfOddNumbers = 0;

            for (int i = 1; i <= numberOfOddNumbers; i++)
            {
                sumOfOddNumbers += oddNubers;
                Console.WriteLine(oddNubers);
                oddNubers += 2;
                

            }
            Console.WriteLine($"Sum: {sumOfOddNumbers}");
        }
    }
}
