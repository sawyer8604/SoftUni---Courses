using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                var multiply = number * i;

                Console.WriteLine($"{number} X {i} = {multiply}");
            }
        }
    }
}
