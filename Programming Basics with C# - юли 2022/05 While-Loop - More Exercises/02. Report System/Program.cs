using System;
class _02_Report
{
    static void Main()
    {


        int expectedSum = int.Parse(Console.ReadLine());

        string input = Console.ReadLine();

        int numberOfCash = 0;
        int numberOfCard = 0;

        double sumCash = 0;
        double sumCard = 0;
        double allCash = 0;
        int allnumber = 0;


        while (input != "End")
        {
            allnumber++;
            int command = int.Parse(input);





            if (allnumber % 2 != 0)
            {
                if (command > 100)
                {
                    Console.WriteLine("Error in transaction!");

                }
                else
                {
                    numberOfCash++;
                    sumCash += command;
                    Console.WriteLine("Product sold!");

                }

            }
            else
            {
                if (command < 10)
                {
                    Console.WriteLine("Error in transaction!");

                }
                else
                {
                    numberOfCard++;
                    sumCard += command;
                    Console.WriteLine("Product sold!");

                }




            }
            allCash = sumCash + sumCard;

            if (allCash >= expectedSum)
            {
                double avarageCash = sumCash / numberOfCash;
                double avarageCard = sumCard / numberOfCard;

                Console.WriteLine($"Average CS: {avarageCash:f2}");
                Console.WriteLine($"Average CC: {avarageCard:f2}");
                break;
            }



            input = Console.ReadLine();
        }


        if (input == "End")
        {
            Console.WriteLine("Failed to collect required money for charity.");


        }


    }
}
