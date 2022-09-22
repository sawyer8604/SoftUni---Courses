using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double result = caslculateRectangleArea(width, height);

            Console.WriteLine(result);


        }

        static double caslculateRectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
