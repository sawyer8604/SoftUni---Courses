using System;

namespace _06._Barcode_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int i = firstNumber / 1000; i <= secondNumber / 1000; i++)
            {
                for (int j = firstNumber / 100 % 10; j <= secondNumber / 100 % 10; j++)
                {
                    for (int k = firstNumber / 10 % 10; k <= secondNumber / 10 % 10; k++)
                    {
                        for (int l = firstNumber % 10; l <= secondNumber % 10; l++)
                        {
                            if (i % 2 != 0 && j % 2 != 0 && k % 2 != 0 && l % 2 != 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }

                        }
                    }
                }
            }

        }
    }
}
