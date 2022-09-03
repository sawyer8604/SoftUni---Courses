using System;

namespace _06EasterDecora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfClients = int.Parse(Console.ReadLine());

            double price = 0;


            for (int clients = 1; clients <= numberOfClients; clients++)
            {
                double priceForClient = 0;
                int counterPerClient = 0;
                string purchase = Console.ReadLine();

                while (purchase != "Finish")
                {


                    switch (purchase)
                    {
                        case "basket":
                            priceForClient += 1.5;
                            counterPerClient++;
                            break;

                        case "wreath":

                            priceForClient += 3.8;
                            counterPerClient++;
                            break;

                        case "chocolate bunny":

                            priceForClient += 7;
                            counterPerClient++;

                            break;


                    }




                    purchase = Console.ReadLine();
                }
                if (counterPerClient % 2 == 0)
                {
                    priceForClient *= 0.8;
                }
                price += priceForClient;


                if (purchase == "Finish")
                {

                    Console.WriteLine($"You purchased {counterPerClient} items for {priceForClient:f2} leva.");
                }
            }
            double avaragePrice = price / numberOfClients;
            Console.WriteLine($"Average bill per client is: {avaragePrice:f2} leva.");
        }
    }
}
