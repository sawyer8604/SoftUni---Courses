using System;

namespace _01._Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimitFirstNumber = int.Parse(Console.ReadLine());
            int upperLimitSecondNumber = int.Parse(Console.ReadLine());
            int upperLimitThirdNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= upperLimitFirstNumber; i++)
            {

                for (int j = 2; j <= upperLimitSecondNumber; j++)
                {


                    for (int k = 1; k <= upperLimitThirdNumber; k++)
                    {

                        if ((i % 2 == 0 && k % 2 == 0) && (j == 2 || j == 3 || j == 5 || j == 7))
                        {

                            Console.WriteLine($"{i} {j} {k}");

                        }


                    }

                }
            }


        }
    }
}
