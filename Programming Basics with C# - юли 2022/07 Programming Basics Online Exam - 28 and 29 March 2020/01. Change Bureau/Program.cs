using System;

namespace _01._Change_Bureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoin = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            commision = commision / 100;

            double bicoinInLev = bitcoin * 1168;

            double yuanInDollar = yuan * 0.15;

            double dollarInLev = yuanInDollar * 1.76;

            double allIinLev = bicoinInLev + dollarInLev;

            double allInEvro = allIinLev / 1.95;

            double allcomission = allInEvro * commision;

            double result = allInEvro - allcomission;

            Console.WriteLine($"{result:f2}");

        }
    }
}
