using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която изчислява каква сума ще получите
             * в края на депозитния период при определен лихвен процент. 
             * Използвайте следната формула:*/
            //1. Депозирана сума – реално число в интервала [100.00 … 10000.00]
            //2.Срок на депозита(в месеци) – цяло число в интервала[1…12]
            //3.Годишен лихвен процент – реално число в интервала[0.00 …100.00

            //сума = депозирана сума + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

            double amountDeposited = double.Parse(Console.ReadLine());
            int TermOfDeposit = int.Parse(Console.ReadLine());
            double yearsRate = double.Parse(Console.ReadLine());


            double rate = amountDeposited * (yearsRate / 100);
            double rateMounth = rate / 12;

            double sum = amountDeposited + TermOfDeposit * rateMounth;
            Console.WriteLine(sum);
        }
    }
}
