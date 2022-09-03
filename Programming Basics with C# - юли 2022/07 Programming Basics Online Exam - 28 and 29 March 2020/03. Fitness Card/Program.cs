using System;
class _03_Energy_Booster
{
    static void Main()
    {

        double money = double.Parse(Console.ReadLine());
        string pol = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string sport = Console.ReadLine();

        double priceOfCard = 0;

        switch (sport)
        {
            case "Gym":

                if (pol == "m")
                {
                    priceOfCard = 42;

                }
                else if (pol == "f")
                {
                    priceOfCard = 35;


                }
                break;


            case "Boxing":

                if (pol == "m")
                {
                    priceOfCard = 41;

                }
                else if (pol == "f")
                {
                    priceOfCard = 37;


                }

                break;

            case "Yoga":

                if (pol == "m")
                {
                    priceOfCard = 45;

                }
                else if (pol == "f")
                {
                    priceOfCard = 42;


                }

                break;

            case "Zumba":

                if (pol == "m")
                {
                    priceOfCard = 34;

                }
                else if (pol == "f")
                {

                    priceOfCard = 31;

                }

                break;

            case "Dances":

                if (pol == "m")
                {
                    priceOfCard = 51;

                }
                else if (pol == "f")
                {
                    priceOfCard = 53;


                }

                break;

            case "Pilates":

                if (pol == "m")
                {
                    priceOfCard = 39;

                }
                else if (pol == "f")
                {
                    priceOfCard = 37;


                }

                break;



        }

        if (age <= 19)
        {
            priceOfCard *= 0.8;

        }

        if (money >= priceOfCard)
        {
            Console.WriteLine($"You purchased a 1 month pass for {sport}.");

        }
        else
        {

            Console.WriteLine($"You don't have enough money! You need ${(priceOfCard - money):f2} more.");
        }


    }
}