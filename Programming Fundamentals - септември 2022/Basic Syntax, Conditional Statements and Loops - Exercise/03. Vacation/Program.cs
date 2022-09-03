using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var countOfPeolpe = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0;
            double allPrice = 0;

            switch (dayOfWeek)
            {
                case "Friday":

                    if (typeOfGroup == "Students")
                    {
                        price = 8.45;

                        if (countOfPeolpe >= 30)
                        {
                            price *= 0.85;
                        }
                        

                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 10.90;
                        if (countOfPeolpe >= 100)
                        {
                            countOfPeolpe -= 10;
                        }
                        

                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = 15;
                        if (countOfPeolpe >= 10 && countOfPeolpe <= 20)
                        {
                            price *= 0.95;
                        }
                    }

                    break;

                case "Saturday":
                    if (typeOfGroup == "Students")
                    {
                        price = 9.80;

                        if (countOfPeolpe >= 30)
                        {
                            price *= 0.85;
                        }


                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 15.60;
                        if (countOfPeolpe >= 100)
                        {
                            countOfPeolpe -= 10;
                        }


                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = 20;
                        if (countOfPeolpe >= 10 && countOfPeolpe <= 20)
                        {
                            price *= 0.95;
                        }
                    }

                    break;

                case "Sunday":

                    if (typeOfGroup == "Students")
                    {
                        price = 10.46;

                        if (countOfPeolpe >= 30)
                        {
                            price *= 0.85;
                        }


                    }
                    else if (typeOfGroup == "Business")
                    {
                        price = 16;
                        if (countOfPeolpe >= 100)
                        {
                            countOfPeolpe -= 10;
                        }


                    }
                    else if (typeOfGroup == "Regular")
                    {
                        price = 22.50;
                        if (countOfPeolpe >= 10 && countOfPeolpe <= 20)
                        {
                            price *= 0.95;
                        }
                    }

                    break;


            }
            allPrice = countOfPeolpe * price;
            Console.WriteLine($"Total price: {allPrice:f2}");
        }
    }
}
