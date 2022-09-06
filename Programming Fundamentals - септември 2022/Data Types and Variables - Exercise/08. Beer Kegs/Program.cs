using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double volumeOfTheKeg = 0;
            double volumeOfTheBiggestKeg = double.MinValue;
            string biggetsKeg = string.Empty;

            for (int i = 0; i < number; i++)
            {

                string modelOfTheKeg = Console.ReadLine();
                double radiusOfTheKeg = double.Parse(Console.ReadLine());
                int heightOfTheKeg = int.Parse(Console.ReadLine());
                volumeOfTheKeg = Math.PI * Math.Pow(radiusOfTheKeg, 2) * heightOfTheKeg;

                if (volumeOfTheKeg > volumeOfTheBiggestKeg)
                {
                    volumeOfTheBiggestKeg = volumeOfTheKeg;
                    biggetsKeg = modelOfTheKeg;

                }
            }
            Console.WriteLine(biggetsKeg);

        }

    }
}
