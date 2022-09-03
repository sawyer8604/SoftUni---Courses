// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;


internal class Program
{
    static void Main(string[] args)
    {
        string season = Console.ReadLine();
        double kilometresForMonth = double.Parse(Console.ReadLine());

        double sum = 0;
        double priceForKm = 0;

        switch (season)
        {


            case "Summer":

                if (kilometresForMonth <= 5000)
                {
                    priceForKm = 0.9;

                }
                else if (kilometresForMonth > 5000 && kilometresForMonth <= 10000)
                {
                    priceForKm = 1.1;

                }
                else if (kilometresForMonth > 10000 && kilometresForMonth <= 20000)
                {
                    priceForKm = 1.45;

                }



                break;

            case "Winter":

                if (kilometresForMonth <= 5000)
                {
                    priceForKm = 1.05;

                }
                else if (kilometresForMonth > 5000 && kilometresForMonth <= 10000)
                {
                    priceForKm = 1.25;

                }
                else if (kilometresForMonth > 10000 && kilometresForMonth <= 20000)
                {
                    priceForKm = 1.45;

                }



                break;


            case "Autumn":
            case "Spring":

                if (kilometresForMonth <= 5000)
                {
                    priceForKm = 0.75;

                }
                else if (kilometresForMonth > 5000 && kilometresForMonth <= 10000)
                {
                    priceForKm = 0.95;

                }
                else if (kilometresForMonth > 10000 && kilometresForMonth <= 20000)
                {
                    priceForKm = 1.45;

                }


                break;


        }
        sum = kilometresForMonth * 4 * priceForKm;
        sum *= 0.9;

        Console.WriteLine($"{sum:f2}");



    }



}
