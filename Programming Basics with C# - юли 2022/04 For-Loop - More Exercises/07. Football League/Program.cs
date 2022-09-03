using System;

namespace _07._Football_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacityOfStadium = int.Parse(Console.ReadLine());
            int numberOfAllFens = int.Parse(Console.ReadLine());

            double fensA = 0;
            double fensB = 0;
            double fensV = 0;
            double fensG = 0;
            double percentFensA = 0;
            double percentFensB = 0;
            double percentFensV = 0;
            double percentFensG = 0;
            double allFens = 0;

            for (int fen = 0; fen < numberOfAllFens; fen++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A":
                        fensA++;


                        break;

                    case "B":
                        fensB++;


                        break;

                    case "V":

                        fensV++;

                        break;

                    case "G":

                        fensG++;

                        break;

                }
            }
            percentFensA = fensA / numberOfAllFens * 100;
            percentFensB = fensB / numberOfAllFens * 100;
            percentFensV = fensV / numberOfAllFens * 100;
            percentFensG = fensG / numberOfAllFens * 100;
            allFens = (fensA + fensB + fensV + fensG) / capacityOfStadium * 100;

            Console.WriteLine($"{percentFensA:f2}%");
            Console.WriteLine($"{percentFensB:f2}%");
            Console.WriteLine($"{percentFensV:f2}%");
            Console.WriteLine($"{percentFensG:f2}%");
            Console.WriteLine($"{allFens:f2}%");

        }
    }
}
