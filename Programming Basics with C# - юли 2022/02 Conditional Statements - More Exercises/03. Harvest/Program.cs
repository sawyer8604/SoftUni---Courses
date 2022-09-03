using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Входът се чете от конзолата и се състои от точно 4 реда:
            //1ви ред: X кв.м е лозето – цяло число в интервала[10 … 5000]
            //2ри ред: Y грозде за един кв.м – реално число в интервала[0.00 … 10.00]
            //3ти ред: Z нужни литри вино – цяло число в интервала[10 … 600]
            //4ти ред: брой работници – цяло число в интервала[1 … 20]

            int vineyard = int.Parse(Console.ReadLine());
            double grapesPerKvm = double.Parse(Console.ReadLine());
            int neededLitresVine = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double grapesForVine = vineyard * 0.4;
            double litreVine = grapesPerKvm / 2.5;
            double allVine = grapesForVine * litreVine;

            double vineLeft = Math.Abs(allVine - neededLitresVine);

            if (allVine >= neededLitresVine)
            {
                double vineForWorkers = vineLeft / numberOfWorkers;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(allVine)} liters.");
                Console.WriteLine($"{Math.Ceiling(vineLeft)} liters left -> {Math.Ceiling(vineForWorkers)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(vineLeft)} liters wine needed.");

            }



        }
    }
}
