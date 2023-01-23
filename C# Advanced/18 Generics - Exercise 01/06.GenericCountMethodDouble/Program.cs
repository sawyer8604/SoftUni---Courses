using System;

namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Box<double> box = new Box<double>();

            for (int i = 0; i < numberOfLines; i++)
            {
                double input = double.Parse(Console.ReadLine());

                box.Items.Add(input);
            }

            double element = double.Parse(Console.ReadLine());

            int countOfBiggerElements = box.CompareElements(element);

            Console.WriteLine(countOfBiggerElements);
        }
    }
}
