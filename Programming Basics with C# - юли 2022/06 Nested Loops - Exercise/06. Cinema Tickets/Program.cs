using System;

namespace _06._Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheMovie = Console.ReadLine();


            int studentCounter = 0;
            int standardCounter = 0;
            int kidCounter = 0;

            double allPercent = 0;
            double allTicketsPercent = 0;


            while (nameOfTheMovie != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                int counter = 0;


                while (freePlaces > counter)
                {

                    string typeOfTickets = Console.ReadLine();

                    if (typeOfTickets == "End")
                    {
                        break;
                    }
                    switch (typeOfTickets)
                    {

                        case "student":

                            studentCounter++;

                            break;

                        case "standard":

                            standardCounter++;

                            break;

                        case "kid":

                            kidCounter++;

                            break;

                    }
                    counter++;

                }

                allPercent = (double)counter / freePlaces * 100;
                allTicketsPercent += counter;

                Console.WriteLine($"{nameOfTheMovie} - {allPercent:f2}% full.");



                nameOfTheMovie = Console.ReadLine();

            }

            Console.WriteLine($"Total tickets: {allTicketsPercent}");
            double percenStudentTicckets = 1.0 * studentCounter / allTicketsPercent * 100;
            double percentStandardTickets = 1.0 * standardCounter / allTicketsPercent * 100;
            double percentKidTickets = 1.0 * kidCounter / allTicketsPercent * 100;
            Console.WriteLine($"{percenStudentTicckets:f2}% student tickets.");
            Console.WriteLine($"{percentStandardTickets:f2}% standard tickets.");
            Console.WriteLine($"{percentKidTickets:f2}% kids tickets.");

        }
    }
}
