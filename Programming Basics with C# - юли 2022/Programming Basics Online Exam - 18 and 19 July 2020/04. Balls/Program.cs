using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());

            int points = 0;
            int numberOfRedBalls = 0;
            int numberOfOrangeBalss = 0;
            int numberOfYellowBals = 0;
            int numberOfWhiteBalls = 0;
            int numberOfBlackBalss = 0;
            int otherColors = 0;

            for (int balls = 0; balls < numberOfBalls; balls++)
            {
                string colors = Console.ReadLine();



                switch (colors)
                {

                    case "red":

                        points += 5;
                        numberOfRedBalls++;

                        break;

                    case "orange":

                        points += 10;
                        numberOfOrangeBalss++;

                        break;

                    case "yellow":

                        points += 15;
                        numberOfYellowBals++;

                        break;

                    case "white":

                        points += 20;
                        numberOfWhiteBalls++;

                        break;

                    case "black":

                        points /= 2;
                        numberOfBlackBalss++;

                        break;



                }
                if (!(colors == "red" || colors == "orange" || colors == "yellow" || colors == "white" || colors == "black"))
                {
                    otherColors++;
                }
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {numberOfRedBalls}");
            Console.WriteLine($"Orange balls: {numberOfOrangeBalss}");
            Console.WriteLine($"Yellow balls: {numberOfYellowBals}");
            Console.WriteLine($"White balls: {numberOfWhiteBalls}");
            Console.WriteLine($"Other colors picked: {otherColors}");
            Console.WriteLine($"Divides from black balls: {numberOfBlackBalss}");


        }


    }
}
