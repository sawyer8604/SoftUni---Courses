using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double currentSum = 0;
            double secondSum = 0;
            double MaxDiff = 0;
            double dif = 0;





            for (int i = 0; i < n; i++)
            {
                secondSum = currentSum;

                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                currentSum = number1 + number2;

                if (i > 0)
                {
                    dif = Math.Abs(currentSum - secondSum);

                    if (dif > MaxDiff)
                    {
                        MaxDiff = dif;
                    }

                }
            }


            if (MaxDiff == 0)
            {

                Console.WriteLine($"Yes, value={currentSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={MaxDiff}");
            }
        }
    }
}
