using System;

namespace _03._Time___15_Minutes___second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hours += 1;
                minutes = minutes - 60;
            }
            if (hours > 23)
            {
                hours = hours - 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
