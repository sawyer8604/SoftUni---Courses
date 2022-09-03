using System;
class _04_Sequence_2k_1
{
    static void Main()

    {
        int number = int.Parse(Console.ReadLine());

        int currentNumber = 0;
        while (currentNumber <= number)
        {

            currentNumber = 2 * currentNumber + 1;
            if (currentNumber <= number)
            {
                Console.WriteLine(currentNumber);

            }
        }

    }
}