using System;
class _07_Min_Number
{
    static void Main()

    {
        string input = Console.ReadLine();

        int minNumber = int.MaxValue;

        while (input != "Stop")
        {
            int currentNumber = int.Parse(input);

            if (input == "Stop")
            {
                break;
            }

            if (currentNumber < minNumber)
            {
                minNumber = currentNumber;
            }


            input = Console.ReadLine();

        }
        Console.WriteLine(minNumber);
    }
}