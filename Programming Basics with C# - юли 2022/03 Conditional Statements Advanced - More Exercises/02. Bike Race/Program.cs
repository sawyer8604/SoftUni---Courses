using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfJuniors = int.Parse(Console.ReadLine());
            int numberOfSeniors = int.Parse(Console.ReadLine());
            string typeOfRace = Console.ReadLine();

            double taxesOfJuniors = 0;
            double taxesOfSeniors = 0;
            double allTaxes = 0;

            switch (typeOfRace)
            {
                case "trail":
                    taxesOfJuniors = 5.50;
                    taxesOfSeniors = 7;
                    allTaxes = (taxesOfJuniors * numberOfJuniors) + (taxesOfSeniors * numberOfSeniors);
                    break;

                case "cross-country":
                    taxesOfJuniors = 8;
                    taxesOfSeniors = 9.5;
                    allTaxes = (taxesOfJuniors * numberOfJuniors) + (taxesOfSeniors * numberOfSeniors);

                    if (numberOfJuniors + numberOfJuniors >= 50)
                    {
                        allTaxes *= 0.75;

                    }

                    break;
                case "downhill":
                    taxesOfJuniors = 12.25;
                    taxesOfSeniors = 13.75;
                    allTaxes = (taxesOfJuniors * numberOfJuniors) + (taxesOfSeniors * numberOfSeniors);

                    break;
                case "road":

                    taxesOfJuniors = 20;
                    taxesOfSeniors = 21.50;
                    allTaxes = (taxesOfJuniors * numberOfJuniors) + (taxesOfSeniors * numberOfSeniors);


                    break;


            }
            allTaxes *= 0.95;

            Console.WriteLine($"{allTaxes:f2}");
        }
    }
}
