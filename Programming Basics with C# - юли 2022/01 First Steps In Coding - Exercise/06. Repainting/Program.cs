using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int safetyNylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int paintThinner = int.Parse(Console.ReadLine());
            int hoursOfFinishWork = int.Parse(Console.ReadLine());

            double safetyNylonPrice = 1.50;
            double paintPrice = 14.50;
            double paintThinnerPrice = 5.00;



            double sumOfNylon = safetyNylon * safetyNylonPrice + 2 * safetyNylonPrice;
            double sumOfPaint = (paint + ((paint * 0.1))) * paintPrice;
            double sumOfThinner = paintThinner * paintThinnerPrice;
            double sumoFPlics = 0.40;
            double sumOfAllMaterials = sumOfNylon + sumOfPaint + sumOfThinner + sumoFPlics;

            double sumForMasters = (sumOfAllMaterials * 0.3) * hoursOfFinishWork;
            double sumOfAll = sumOfAllMaterials + sumForMasters;


            Console.WriteLine(sumOfAll);


        }
    }
}
