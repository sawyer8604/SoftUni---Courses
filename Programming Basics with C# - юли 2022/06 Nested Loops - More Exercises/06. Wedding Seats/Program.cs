using System;

namespace _06._Wedding_Seats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int numberOfRowsInFirstSector = int.Parse(Console.ReadLine());
            int numberOfOddPaces = int.Parse(Console.ReadLine());
            int places = 0;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                numberOfRowsInFirstSector += 1;

                for (int number = 1; number < numberOfRowsInFirstSector; number++)
                {

                    if (number % 2 != 0)
                    {
                        places += numberOfOddPaces;
                        for (char thirdSymbol = 'a'; thirdSymbol <= 'a' + numberOfOddPaces - 1; thirdSymbol++)
                        {
                            Console.WriteLine($"{sector}{number}{thirdSymbol} ");
                        }
                    }
                    else
                    {
                        places += numberOfOddPaces + 2;
                        for (char thirdSymbol = 'a'; thirdSymbol <= 'a' + numberOfOddPaces + 1; thirdSymbol++)
                        {
                            Console.WriteLine($"{sector}{number}{thirdSymbol} ");
                        }
                    }


                }
            }
            Console.WriteLine(places);
        }
    }
}
