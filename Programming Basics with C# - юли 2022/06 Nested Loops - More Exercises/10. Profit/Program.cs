using System;

namespace _10._Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMonetsPerOne = int.Parse(Console.ReadLine());
            int numberOfMonetsPerTwo = int.Parse(Console.ReadLine());
            int numberOfMonetsPerFive = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numberOfMonetsPerOne; i++)
            {

                for (int j = 0; j <= numberOfMonetsPerTwo; j++)
                {

                    for (int k = 0; k <= numberOfMonetsPerFive; k++)
                    {
                        if (i * 1 + j * 2 + k * 5 == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }


                    }
                }
            }
        }
    }
}
