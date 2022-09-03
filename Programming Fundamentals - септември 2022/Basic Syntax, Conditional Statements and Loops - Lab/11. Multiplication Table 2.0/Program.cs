using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            var multyply = 0;

            do
            {
                multyply = number * multiplier;

                Console.WriteLine($"{number} X {multiplier} = {multyply}");
                multiplier++;

            } while (multiplier <= 10);

        }
    }
}
