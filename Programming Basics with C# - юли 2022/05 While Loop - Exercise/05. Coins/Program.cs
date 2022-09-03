using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coins = double.Parse(Console.ReadLine());
            double allcoins = Math.Floor(coins * 100);
            int numberOfCoins = 0;

            while (allcoins != 0)
            {
                if (allcoins - 200 >= 0)
                {
                    allcoins -= 200;
                    numberOfCoins++;

                }
                else if (allcoins - 100 >= 0)
                {
                    allcoins -= 100;
                    numberOfCoins++;

                }
                else if (allcoins - 50 >= 0)
                {
                    allcoins -= 50;
                    numberOfCoins++;

                }
                else if (allcoins - 20 >= 0)
                {
                    allcoins -= 20;
                    numberOfCoins++;

                }
                else if (allcoins - 10 >= 0)
                {
                    allcoins -= 10;
                    numberOfCoins++;

                }
                else if (allcoins - 5 >= 0)
                {
                    allcoins -= 5;
                    numberOfCoins++;

                }
                else if (allcoins - 2 >= 0)
                {
                    allcoins -= 2;
                    numberOfCoins++;

                }
                else if (allcoins - 1 >= 0)
                {
                    allcoins -= 1;
                    numberOfCoins++;

                }


            }

            Console.WriteLine(numberOfCoins);

        }
    }
}
