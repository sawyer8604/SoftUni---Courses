using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            bool isDay = day == "Monday" || day == "Tuesday" || day == "Friday";
            bool isDay1 = day == "Wednesday" || day == "Thursday";
            bool isDay2 = day == "Saturday" || day == "Sunday";

            if (isDay)
            {
                Console.WriteLine(12);
            }
            else if (isDay1)
            {
                Console.WriteLine(14);
            }
            else if (isDay2)
            {
                Console.WriteLine(16);
            }
        }
    }
}
