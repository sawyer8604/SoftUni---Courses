using System;

namespace _03._Aluminum_Joinery_Условие
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfJoinery = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string delivery = Console.ReadLine();

            double price = 0;

            if (numberOfJoinery < 10)
            {

                Console.WriteLine("Invalid order");
            }
            else
            {
                switch (size)
                {
                    case "90X130":
                        price = 110;

                        if (numberOfJoinery > 30 && numberOfJoinery <= 60)
                        {
                            price *= 0.95;

                        }
                        else if (numberOfJoinery > 60)
                        {
                            price *= 0.92;

                        }
                        break;


                    case "100X150":
                        price = 140;

                        if (numberOfJoinery > 40 && numberOfJoinery <= 80)
                        {
                            price *= 0.94;

                        }
                        else if (numberOfJoinery > 80)
                        {
                            price *= 0.90;

                        }

                        break;

                    case "130X180":



                        price = 190;

                        if (numberOfJoinery > 20 && numberOfJoinery <= 50)
                        {
                            price *= 0.93;

                        }
                        else if (numberOfJoinery > 50)
                        {
                            price *= 0.88;

                        }

                        break;

                    case "200X300":

                        price = 250;

                        if (numberOfJoinery > 25 && numberOfJoinery <= 50)
                        {
                            price *= 0.91;

                        }
                        else if (numberOfJoinery > 50)
                        {
                            price *= 0.86;

                        }

                        break;


                }
                price *= numberOfJoinery;

                if (delivery == "With delivery")
                {

                    price = price + 60;
                }
                if (numberOfJoinery > 99)
                {

                    price *= 0.96;
                }

                Console.WriteLine($"{price:f2} BGN");
            }

        }
    }
}
