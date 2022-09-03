using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1. Дължина в см – цяло число в интервала [10 … 500]

            2. Широчина в см – цяло число в интервала [10 … 300]

            3. Височина в см – цяло число в интервала [10… 200]

            4. Процент – реално число в интервала [0.000 … 100.000] */

            //input 

            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            //calculation

            int aquariumCapacity = lenght * width * height;
            double capacityInLitres = aquariumCapacity * 0.001;
            double spaceTakken = percent / 100;
            double needetLitres = capacityInLitres * (1 - spaceTakken);

            Console.WriteLine(needetLitres);


        }
    }
}
