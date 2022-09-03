using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            double finalPoints = 0;
            double avaragePoints = 0;
            double percentWins = 0;
            double numberOfWinf = 0;

            for (int number = 0; number < numberOfTournaments; number++)
            {
                string stageOfTournaments = Console.ReadLine();

                switch (stageOfTournaments)
                {
                    case "W":
                        points += 2000;
                        avaragePoints += 2000;
                        numberOfWinf++;

                        break;

                    case "F":
                        points += 1200;
                        avaragePoints += 1200;

                        break;

                    case "SF":
                        points += 720;
                        avaragePoints += 720;

                        break;

                }

            }
            avaragePoints /= numberOfTournaments;
            percentWins = numberOfWinf / numberOfTournaments * 100;
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(avaragePoints)}");
            Console.WriteLine($"{percentWins:f2}%");

        }
    }
}
