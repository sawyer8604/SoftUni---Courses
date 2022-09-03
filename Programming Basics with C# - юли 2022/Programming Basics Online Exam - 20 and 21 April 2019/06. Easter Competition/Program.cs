using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCozunac = int.Parse(Console.ReadLine());
            int maxPoints = int.MinValue;
            string name = string.Empty;

            for (int i = 1; i <= numberOfCozunac; i++)
            {
                int points = 0;

                string nameOfBaker = Console.ReadLine();
                string input = Console.ReadLine();
                while (input != "Stop")
                {
                    int command = int.Parse(input);

                    points += command;


                    input = Console.ReadLine();

                }
                Console.WriteLine($"{nameOfBaker} has {points} points.");
                if (maxPoints < points)
                {
                    maxPoints = points;
                    name = nameOfBaker;
                    Console.WriteLine($"{name} is the new number 1!");
                }


            }
            Console.WriteLine($"{name} won competition with {maxPoints} points!");
        }
    }
}
