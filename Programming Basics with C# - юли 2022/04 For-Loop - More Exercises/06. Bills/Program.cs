using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            double water = 0;
            double internet = 0;
            double others = 0;
            double average = 0;
            double allElectricity = 0;

            for (int number = 0; number < month; number++)
            {
                double electricity = double.Parse(Console.ReadLine());
                allElectricity += electricity;
                water += 20;
                internet += 15;


            }
            others += (water + internet + allElectricity) * 1.2;
            average = (allElectricity + water + internet + others) / month;
            Console.WriteLine($"Electricity: {allElectricity:f2} lv");
            Console.WriteLine($"Water: {water:f} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
