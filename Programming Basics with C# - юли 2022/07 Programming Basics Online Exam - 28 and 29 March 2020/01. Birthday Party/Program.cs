using System;

namespace _01._Birthday_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hallRent = double.Parse(Console.ReadLine());

            double torta = hallRent * 0.2;
            double drinks = torta * 0.55;
            double animator = hallRent / 3;

            double allPrice = hallRent + torta + drinks + animator;

            Console.WriteLine($"{allPrice}");


        }
    }
}
