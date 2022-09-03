using System;

namespace _06_1._Circle_Area_and_Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter circle radius. r = ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");

        }
    }
}
