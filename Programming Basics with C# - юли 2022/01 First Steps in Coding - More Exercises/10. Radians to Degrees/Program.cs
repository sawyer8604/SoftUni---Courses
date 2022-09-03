using System;

namespace _10_1._Radians_to_Degrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //: градус = радиан * 180 / π.
            double radians = double.Parse(Console.ReadLine());
            double graduses = radians * 180 / Math.PI;
            Console.WriteLine(Math.Round(graduses));
        }
    }
}
