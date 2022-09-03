using System;

namespace _03._Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int firstNumber = 0; firstNumber <= number; firstNumber++)
            {

                for (int secondNumber = 0; secondNumber <= number; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= number; thirdNumber++)
                    {
                        if (firstNumber + secondNumber + thirdNumber == number)

                        {
                            counter++;

                        }

                    }


                }
            }

            Console.WriteLine(counter);
        }
    }
}
