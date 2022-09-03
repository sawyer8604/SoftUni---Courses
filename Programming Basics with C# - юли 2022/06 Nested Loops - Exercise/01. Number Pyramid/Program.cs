using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{counter} ");
                    counter++;
                    if (counter > number)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (counter > number)
                {
                    break;
                }
            }
        }
    }
}
