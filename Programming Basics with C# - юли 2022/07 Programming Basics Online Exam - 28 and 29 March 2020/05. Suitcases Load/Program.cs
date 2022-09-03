using System;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double capacity = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int counter = 0;

            while (input != "End")
            {
                counter++;
                double command = double.Parse(input);


                if (counter % 3 == 0)
                {
                    command *= 1.1;

                }
                capacity -= command;

                if (capacity < 0)
                {
                    counter--;
                    break;
                }



                input = Console.ReadLine();

            }

            if (input == "End")
            {

                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            else if (capacity < 0)
            {

                Console.WriteLine("No more space!");
            }

            Console.WriteLine($"Statistic: {counter} suitcases loaded.");
        }
    }
}
