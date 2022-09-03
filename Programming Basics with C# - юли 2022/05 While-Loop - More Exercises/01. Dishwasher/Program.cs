using System;
class _01_Dishwasher
{
    static void Main()
    {

        int numberOfDetergent = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        double allBotles = numberOfDetergent * 750.0;
        int counter = 0;
        double plates = 5;
        double pots = 15;
        int numberOfPlates = 0;
        int numberOfPots = 0;

        while (input != "End")
        {


            int command = int.Parse(input);
            counter++;

            if (counter == 3)
            {
                numberOfPots += command;
                allBotles -= pots * command;
                counter = 0;

            }
            else
            {

                allBotles -= plates * command;
                numberOfPlates += command;
            }
            if (allBotles < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(allBotles)} ml. more necessary!");
                return;
            }


            input = Console.ReadLine();

        }

        Console.WriteLine($"Detergent was enough!\r\n{numberOfPlates} dishes and {numberOfPots} pots were washed.");
        Console.WriteLine($"Leftover detergent {allBotles} ml.");
    }
}