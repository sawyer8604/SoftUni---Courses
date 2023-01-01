using System;

namespace _06.GenericCountMethodDouble
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            double numberOfLines = double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < numberOfLines; i++)
            {
                double input = double.Parse(Console.ReadLine());

                box.Items.Add(input);

            }

            double elementToCompare = double.Parse(Console.ReadLine());

            Console.WriteLine(box.Count(elementToCompare));


        }
    }
}
