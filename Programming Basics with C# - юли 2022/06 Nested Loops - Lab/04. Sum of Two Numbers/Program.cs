using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool isFindMagicNumber = false;

            for (int firstNumber = beginNumber; firstNumber <= endNumber; firstNumber++)
            {

                for (int secondNumber = beginNumber; secondNumber <= endNumber; secondNumber++)
                {
                    counter++;

                    if (firstNumber + secondNumber == magicNumber)
                    {
                        isFindMagicNumber = true;
                        Console.WriteLine($"Combination N:{counter} ({firstNumber} + {secondNumber} = {magicNumber})");

                        break;
                    }
                }
                if (isFindMagicNumber)
                {
                    break;
                }


            }
            if (!isFindMagicNumber)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
