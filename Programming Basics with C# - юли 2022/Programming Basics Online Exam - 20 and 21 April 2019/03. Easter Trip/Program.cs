using System;

namespace _03._Easter_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            double allPrice = 0;

            switch (destination)
            {
                case "France":

                    if (dates == "21-23")
                    {
                        pricePerNight = 30;
                    }
                    else if (dates == "24-27")
                    {
                        pricePerNight = 35;
                    }
                    else if (dates == "28-31")
                    {
                        pricePerNight = 40;

                    }

                    break;

                case "Italy":

                    if (dates == "21-23")
                    {
                        pricePerNight = 28;
                    }
                    else if (dates == "24-27")
                    {
                        pricePerNight = 32;
                    }
                    else if (dates == "28-31")
                    {
                        pricePerNight = 39;

                    }

                    break;

                case "Germany":

                    if (dates == "21-23")
                    {
                        pricePerNight = 32;
                    }
                    else if (dates == "24-27")
                    {
                        pricePerNight = 37;
                    }
                    else if (dates == "28-31")
                    {
                        pricePerNight = 43;

                    }

                    break;

            }


            allPrice = numberOfNights * pricePerNight;
            Console.WriteLine($"Easter trip to {destination} : {allPrice:f2} leva.");


        }
    }
}
