using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDay = int.Parse(Console.ReadLine());

            string [] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            if (numberOfDay > 0 && numberOfDay <= 7)
            {

                Console.WriteLine(days[numberOfDay -1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
