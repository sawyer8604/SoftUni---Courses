using System;

namespace _3Painting_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sizeOfEggs = Console.ReadLine();
            string colorOfEggs = Console.ReadLine();
            int numberOfPartides = int.Parse(Console.ReadLine());

            double priceOfEggs = 0;
            double allPrice = 0;

            switch (sizeOfEggs)
            {
                case "Large":

                    if (colorOfEggs == "Red")
                    {
                        priceOfEggs = 16;
                    }
                    else if (colorOfEggs == "Green")
                    {
                        priceOfEggs = 12;

                    }
                    else if (colorOfEggs == "Yellow")
                    {
                        priceOfEggs = 9;

                    }

                    break;

                case "Medium":

                    if (colorOfEggs == "Red")
                    {
                        priceOfEggs = 13;
                    }
                    else if (colorOfEggs == "Green")
                    {
                        priceOfEggs = 9;

                    }
                    else if (colorOfEggs == "Yellow")
                    {
                        priceOfEggs = 7;

                    }

                    break;

                case "Small":

                    if (colorOfEggs == "Red")
                    {
                        priceOfEggs = 9;
                    }
                    else if (colorOfEggs == "Green")
                    {
                        priceOfEggs = 8;

                    }
                    else if (colorOfEggs == "Yellow")
                    {
                        priceOfEggs = 5;

                    }

                    break;


            }

            allPrice = numberOfPartides * priceOfEggs * 0.65;
            Console.WriteLine($"{allPrice:f2} leva.");
        }
    }
}
