using System;

namespace _04._Inches_to_Centimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read input from the user

            double numbers = double.Parse(Console.ReadLine());

            // Logical conversion

            double inches = 2.54;
            double centimeters = numbers * inches;

            // Printing to result on the console

            Console.WriteLine(centimeters);
        }
    }
}
