using System;

namespace _01._Black_Flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double allPlunder = 0;
            double percent = 0;

            for (int i = 1; i <= days; i++)
            {
                allPlunder += dailyPlunder;

                if(i % 3 == 0)
                {
                    allPlunder += dailyPlunder * 0.5;
                }

                if(i % 5 == 0)
                {
                    allPlunder *= 0.7;
                }
            }

            percent = allPlunder / expectedPlunder * 100.0;

            if (allPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {allPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {percent:f2}% of the plunder.");
            }
        }
    }
}
