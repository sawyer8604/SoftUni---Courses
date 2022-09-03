using System;

namespace _03._Sum_Prime_Non_Prime_Second_Way
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumOfPrimeNumber = 0;
            int sumOfNonPrimeNumber = 0;


            while (input != "stop")
            {
                int currentNumber = int.Parse(input);
                int counter = 0;
                if (currentNumber < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;

                }

                for (int i = 1; i <= currentNumber; i++)
                {

                    if (currentNumber % i == 0)
                    {
                        counter++;


                    }

                }
                if (counter == 2)
                {
                    sumOfPrimeNumber += currentNumber;


                }
                else
                {
                    sumOfNonPrimeNumber += currentNumber;

                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {sumOfPrimeNumber}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumOfNonPrimeNumber}");
        }
    }
}
