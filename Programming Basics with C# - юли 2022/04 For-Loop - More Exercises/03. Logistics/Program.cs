using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCargo = int.Parse(Console.ReadLine());
            double priceFotTon = 0;
            double avaragePriceForTon = 0;

            double allTonsOfCargo = 0, percentMikrobus = 0, precentTruck = 0, percentTrain = 0;
            double allprecentMikrobus = 0, allprecentTruck = 0, allpercentTrain = 0;




            for (int cargo = 1; cargo <= numberOfCargo; cargo++)
            {
                int tonnsOfCargo = int.Parse(Console.ReadLine());

                allTonsOfCargo += tonnsOfCargo;

                if (tonnsOfCargo <= 3)
                {
                    priceFotTon += 200 * tonnsOfCargo;
                    percentMikrobus += tonnsOfCargo;



                }
                else if (tonnsOfCargo > 3 && tonnsOfCargo <= 11)
                {
                    priceFotTon += 175 * tonnsOfCargo;
                    precentTruck += tonnsOfCargo;


                }
                else if (tonnsOfCargo > 11)
                {
                    priceFotTon += 120 * tonnsOfCargo;
                    percentTrain += tonnsOfCargo;

                }
            }
            avaragePriceForTon = priceFotTon / allTonsOfCargo;
            allprecentMikrobus = percentMikrobus / allTonsOfCargo * 100;
            allprecentTruck = precentTruck / allTonsOfCargo * 100;
            allpercentTrain = percentTrain / allTonsOfCargo * 100;

            Console.WriteLine($"{avaragePriceForTon:f2}");

            Console.WriteLine($"{allprecentMikrobus:f2}%");
            Console.WriteLine($"{allprecentTruck:f2}%");
            Console.WriteLine($"{allpercentTrain:f2}%");


        }
    }
}
