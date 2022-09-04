using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Length: ");

            double lengnht = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            double widht = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            double height = double.Parse(Console.ReadLine());

            double  volume = (lengnht * widht * height) / 3;

            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}
