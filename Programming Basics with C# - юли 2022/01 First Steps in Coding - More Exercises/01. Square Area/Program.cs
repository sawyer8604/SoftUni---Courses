using System;

namespace _01_1._Square_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            Console.Write("Square area = ");
            Console.WriteLine(area);
        }
    }
}
