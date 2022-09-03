using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;

            while (steps < 10000)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int homeSteps = int.Parse(Console.ReadLine());
                    steps += homeSteps;
                    break;
                }
                else
                {

                    steps += int.Parse(input);

                }

            }
            if (steps >= 10000)
            {
                Console.WriteLine($"Goal reached! Good job!\r\n{steps - 10000} steps over the goal!");
            }
            else
            {

                Console.WriteLine($"{10000 - steps} more steps to reach goal.");
            }
        }
    }
}
