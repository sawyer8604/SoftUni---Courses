using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int maxNuber = int.MinValue;

            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);

                if (input == "Stop")
                {
                    break;
                }
                if (currentNumber > maxNuber)
                {

                    maxNuber = currentNumber;
                }


                input = Console.ReadLine();


            }
            Console.WriteLine(maxNuber);


        }
    }
}
