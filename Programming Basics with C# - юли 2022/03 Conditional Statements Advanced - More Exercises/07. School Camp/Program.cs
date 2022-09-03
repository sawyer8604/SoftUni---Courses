// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace MyApp_07_SchoolCamp
{

    internal class Program
    {
        static void Main(string[] args)
        {

            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfNights = int.Parse(Console.ReadLine());

            double priceOfNights = 0;
            string sportForPractice = string.Empty;
            double sum = 0;


            switch (season)
            {

                case "Winter":
                    if (typeOfGroup == "boys")
                    {
                        priceOfNights = 9.6;
                        sportForPractice = "Judo";

                    }
                    else if (typeOfGroup == "girls")
                    {
                        priceOfNights = 9.6;
                        sportForPractice = "Gymnastics";


                    }
                    else if (typeOfGroup == "mixed")
                    {
                        priceOfNights = 10;
                        sportForPractice = "Ski";


                    }


                    break;

                case "Spring":


                    if (typeOfGroup == "boys")
                    {
                        priceOfNights = 7.2;
                        sportForPractice = "Tennis";

                    }
                    else if (typeOfGroup == "girls")
                    {
                        priceOfNights = 7.2;
                        sportForPractice = "Athletics";


                    }
                    else if (typeOfGroup == "mixed")
                    {
                        priceOfNights = 9.5;
                        sportForPractice = "Cycling";


                    }

                    break;

                case "Summer":

                    if (typeOfGroup == "boys")
                    {
                        priceOfNights = 15;
                        sportForPractice = "Football";

                    }
                    else if (typeOfGroup == "girls")
                    {
                        priceOfNights = 15;
                        sportForPractice = "Volleyball";


                    }
                    else if (typeOfGroup == "mixed")
                    {
                        priceOfNights = 20;
                        sportForPractice = "Swimming";


                    }

                    break;


            }

            sum = numberOfStudents * numberOfNights * priceOfNights;

            if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                sum *= 0.95;

            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)

            {

                sum *= 0.85;
            }
            else if (numberOfStudents >= 50)

            {

                sum *= 0.5;
            }

            Console.WriteLine($"{sportForPractice} {sum:f2} lv.");

        }

    }

}
