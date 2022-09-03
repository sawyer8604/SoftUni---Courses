using System;

namespace _05._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPaintedEgss = int.Parse(Console.ReadLine());
            string colorOfEggs = Console.ReadLine();

            int redCounter = 0;
            int orangeCounter = 0;
            int blueCounter = 0;
            int greenCounter = 0;
            int maxEggs = 0;
            string color = string.Empty;


            while (true)
            {


                numberOfPaintedEgss--;


                switch (colorOfEggs)
                {
                    case "red":

                        redCounter++;


                        break;

                    case "orange":

                        orangeCounter++;

                        break;

                    case "blue":

                        blueCounter++;


                        break;

                    case "green":

                        greenCounter++;


                        break;

                }
                if (maxEggs < redCounter)
                {
                    maxEggs = redCounter;
                    color = "red";
                }
                else if (maxEggs < orangeCounter)
                {
                    maxEggs = orangeCounter;
                    color = "orange";
                }
                else if (maxEggs < blueCounter)
                {
                    maxEggs = blueCounter;
                    color = "blue";
                }
                else if (maxEggs < greenCounter)
                {
                    maxEggs = greenCounter;
                    color = "green";
                }
                colorOfEggs = Console.ReadLine();
                if (numberOfPaintedEgss <= 0)
                {
                    break;
                }


            }
            Console.WriteLine($"Red eggs: {redCounter}");
            Console.WriteLine($"Orange eggs: {orangeCounter}");
            Console.WriteLine($"Blue eggs: {blueCounter}");
            Console.WriteLine($"Green eggs: {greenCounter}");

            Console.WriteLine($"Max eggs: {maxEggs} -> {color}");

        }
    }
}
