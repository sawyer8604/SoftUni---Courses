using System;

namespace _03._Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());

            
            double firstResult = longestLine(x1, y1, x2, y2);
            double secondResult = longestLine(a1, b1, a2, b2);


            if (firstResult > secondResult)
            {
                double firstMaxNUm = Math.Max(Math.Abs(x1), Math.Abs(y1));
                double secondMaxNum = Math.Max(Math.Abs(x2), Math.Abs(y2));
                if (firstMaxNUm <= secondMaxNum)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");

                }
            }
            else
            {
                double firstMaxNUm = Math.Max(Math.Abs(a1), Math.Abs(b1));
                double secondMaxNum = Math.Max(Math.Abs(a2), Math.Abs(b2));
                if (firstMaxNUm <= secondMaxNum)
                {
                    Console.WriteLine($"({a1}, {b1})({a2}, {b2})");
                }
                else
                {
                    Console.WriteLine($"({a2}, {b2})({a1}, {b1})");

                }

            }
        }

        private static double longestLine(double x1, double y1, double x2, double y2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
            return result;
        }
    }
}
