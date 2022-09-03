using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heritageMoney = double.Parse(Console.ReadLine());
            int yearsOfLiving = int.Parse(Console.ReadLine());
            double evenMoney = 0;
            double oddMoney = 0;
            double allSum = 0;
            int yearsOfIvancho = 17;


            for (int years = 1800; years <= yearsOfLiving; years++)
            {


                if (years % 2 == 0)
                {
                    evenMoney += 12000;

                }
                else
                {
                    yearsOfIvancho += 2;

                    oddMoney = oddMoney + 12000 + 50 * yearsOfIvancho;
                }
            }


            allSum = evenMoney + oddMoney;


            if (allSum <= heritageMoney)
            {

                Console.WriteLine($"Yes! He will live a carefree life and will have {(heritageMoney - allSum):f2} dollars left.");
            }
            else
            {

                Console.WriteLine($"He will need {(allSum - heritageMoney):f2} dollars to survive.");
            }
        }
    }
}
