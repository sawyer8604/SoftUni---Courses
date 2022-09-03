using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double sum = 0;

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":

                    if (fruit == "banana")
                    {
                        sum = quantity * 2.50;
                    }
                    else if (fruit == "apple")
                    {
                        sum = quantity * 1.20;
                    }

                    else if (fruit == "orange")
                    {
                        sum = quantity * 0.85;
                    }
                    else if (fruit == "grapefruit")
                    {
                        sum = quantity * 1.45;
                    }
                    else if (fruit == "kiwi")
                    {
                        sum = quantity * 2.70;
                    }
                    else if (fruit == "pineapple")
                    {
                        sum = quantity * 5.50;
                    }
                    else if (fruit == "grapes")
                    {
                        sum = quantity * 3.85;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }


                    break;

                case "Saturday":
                case "Sunday":

                    if (fruit == "banana")
                    {
                        sum = quantity * 2.70;
                    }
                    else if (fruit == "apple")
                    {
                        sum = quantity * 1.25;
                    }
                    else if (fruit == "orange")
                    {
                        sum = quantity * 0.90;
                    }

                    else if (fruit == "grapefruit")
                    {
                        sum = quantity * 1.60;
                    }
                    else if (fruit == "kiwi")
                    {
                        sum = quantity * 3.00;
                    }
                    else if (fruit == "pineapple")
                    {
                        sum = quantity * 5.60;
                    }
                    else if (fruit == "grapes")
                    {
                        sum = quantity * 4.20;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;


            }
            if (sum > 0)
            {

                Console.WriteLine($"{sum:f2}");
            }
        }

    }
}
