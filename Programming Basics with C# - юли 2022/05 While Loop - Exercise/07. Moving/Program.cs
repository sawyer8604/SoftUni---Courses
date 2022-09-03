using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int allSpace = width * length * height;
            int usedSpace = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int command = int.Parse(input);

                usedSpace += command;
                if (allSpace <= usedSpace)
                {
                    Console.WriteLine($"No more free space! You need {usedSpace - allSpace} Cubic meters more.");
                    return;
                }


                input = Console.ReadLine();


            }
            Console.WriteLine($"{allSpace - usedSpace} Cubic meters left.");

        }
    }
}
