using System;

namespace _05.Easter_Bake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCozunac = int.Parse(Console.ReadLine());
            double shugar = 0;
            double flour = 0;
            double numberOfShugar = 0;
            double numberOfOfflour = 0;

            int maxShugar = int.MinValue;
            int maxOfflour = int.MinValue;

            for (int cozunac = 1; cozunac <= numberOfCozunac; cozunac++)
            {

                int countOfShugar = int.Parse(Console.ReadLine());
                int countOfOfflour = int.Parse(Console.ReadLine());

                shugar += countOfShugar;
                flour += countOfOfflour;

                if (countOfShugar > maxShugar)
                {
                    maxShugar = countOfShugar;
                }
                if (countOfOfflour > maxOfflour)
                {
                    maxOfflour = countOfOfflour;
                }

            }
            numberOfShugar = Math.Ceiling(shugar / 950);
            numberOfOfflour = Math.Ceiling(flour / 750);
            Console.WriteLine($"Sugar: {numberOfShugar}");
            Console.WriteLine($"Flour: {numberOfOfflour}");
            Console.WriteLine($"Max used flour is {maxOfflour} grams, max used sugar is {maxShugar} grams.");

        }
    }
}
