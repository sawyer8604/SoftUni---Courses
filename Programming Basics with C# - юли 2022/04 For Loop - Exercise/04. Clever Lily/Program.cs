using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageOfLilly = int.Parse(Console.ReadLine());
            double priceOfWashingMachine = double.Parse(Console.ReadLine());
            int priceOfToy = int.Parse(Console.ReadLine());
            double BankForEvenBirthDay = 0;
            double cashForBirthDay = 10;
            int oddBurthDays = 0;
            int evenBirthdays = 0;
            double allMoney = 0;

            for (int birthday = 1; birthday <= ageOfLilly; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    evenBirthdays++;
                    BankForEvenBirthDay += cashForBirthDay;
                    cashForBirthDay += 10;
                }
                else
                {
                    oddBurthDays++;

                }

            }
            BankForEvenBirthDay = BankForEvenBirthDay - evenBirthdays;
            double priceOfAlltoys = priceOfToy * oddBurthDays;
            allMoney = BankForEvenBirthDay + priceOfAlltoys;

            if (allMoney >= priceOfWashingMachine)
            {

                Console.WriteLine($"Yes! {Math.Abs(priceOfWashingMachine - allMoney):f2}");
            }
            else
            {

                Console.WriteLine($"No! {Math.Abs(priceOfWashingMachine - allMoney):f2}");
            }
        }
    }
}
