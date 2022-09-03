using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pool = int.Parse(Console.ReadLine());
            int firstPipes = int.Parse(Console.ReadLine());
            int secondPpies = int.Parse(Console.ReadLine());
            double hoursWrkerLeft = double.Parse(Console.ReadLine());

            double allPipes = (firstPipes + secondPpies) * hoursWrkerLeft;
            double pipes1Inpercent = (firstPipes * hoursWrkerLeft * 100) / allPipes;
            double pipes2Inpercent = (secondPpies * 100 * hoursWrkerLeft) / allPipes;
            double allPpipesInpercent = allPipes * 100 / pool;

            if (allPipes <= pool)
            {
                Console.WriteLine($"The pool is {allPpipesInpercent:f2}% full. Pipe 1: {pipes1Inpercent:f2}%. Pipe 2: {pipes2Inpercent:f2}%.");

            }
            else
            {
                Console.WriteLine($"For {hoursWrkerLeft:f2} hours the pool overflows with {allPipes - pool:f2} liters.");
            }



        }
    }
}
