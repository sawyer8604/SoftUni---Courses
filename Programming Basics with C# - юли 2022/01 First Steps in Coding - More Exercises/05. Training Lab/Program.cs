using System;

namespace _05._Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine()); // дължина
            double weight = double.Parse(Console.ReadLine()); //широчина

            double smLength = length * 100;
            double smWeight = weight * 100;
            double l1 = Math.Floor((smLength) / 120);
            double l2 = Math.Floor((smWeight - 100) / 70);

            Console.WriteLine(Math.Floor(l1));
            Console.WriteLine(Math.Floor(l2));


            double places = l1 * l2 - 3;
            Console.WriteLine(Math.Floor(places));
        }
    }
}
