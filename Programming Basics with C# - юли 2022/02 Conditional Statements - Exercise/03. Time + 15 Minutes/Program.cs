using System;

namespace P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int sum = ((hours * 60) + minutes + 15);
            int hoursResult = sum / 60;

            if (hoursResult >= 24)
            {
                hoursResult -= 24;
            }
            int minutesResult = sum % 60;

            if (minutesResult < 10)
            {
                Console.WriteLine($"{hoursResult}:0{minutesResult}");
            }
            else
            {
                Console.WriteLine($"{hoursResult}:{minutesResult}");

            }
        }

    }


}
