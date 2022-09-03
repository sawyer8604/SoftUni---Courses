/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class _03_Energy_Booster
{
    static void Main()
    {


        string fruit = Console.ReadLine();
        string setSize = Console.ReadLine();
        int numberOfSet = int.Parse(Console.ReadLine());

        double priceOFSet = 0;

        double allPrice = 0;



        switch (fruit)
        {

            case "Watermelon":

                if (setSize == "small")
                {
                    priceOFSet = 2 * 56;

                }
                else if (setSize == "big")
                {
                    priceOFSet = 5 * 28.70;

                }

                break;

            case "Mango":

                if (setSize == "small")
                {
                    priceOFSet = 2 * 36.66;


                }
                else if (setSize == "big")
                {
                    priceOFSet = 5 * 19.60;



                }


                break;

            case "Pineapple":

                if (setSize == "small")
                {
                    priceOFSet = 2 * 42.10;


                }
                else if (setSize == "big")
                {
                    priceOFSet = 5 * 24.80;

                }


                break;

            case "Raspberry":

                if (setSize == "small")
                {

                    priceOFSet = 2 * 20;
                }
                else if (setSize == "big")
                {
                    priceOFSet = 5 * 15.20;

                }


                break;



        }

        allPrice = priceOFSet * numberOfSet;

        if (allPrice >= 400 && allPrice <= 1000)
        {
            allPrice *= 0.85;

        }

        if (allPrice > 1000)
        {
            allPrice *= 0.5;


        }
        Console.WriteLine($"{allPrice:f2} lv.");
    }
}
