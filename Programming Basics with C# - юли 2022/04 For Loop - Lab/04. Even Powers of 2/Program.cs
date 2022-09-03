using System;

namespace _04._Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberForCykle = int.Parse(Console.ReadLine());

            int number = 1;

            for (int i = 0; i <= numberForCykle; i += 2)
            {

                Console.WriteLine(number);

                number *= 2 * 2;


            }

        }
    }
}
