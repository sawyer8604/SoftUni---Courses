using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBreakeDay = int.Parse(Console.ReadLine());
            int timeForGames = 30000;
            int dayForWork = 365 - numberOfBreakeDay;
            int timeForgamesWhenInWork = dayForWork * 63;
            int timeForGamesWhenInBreak = numberOfBreakeDay * 127;
            int allTimesforGame = timeForgamesWhenInWork + timeForGamesWhenInBreak;

            if (allTimesforGame > timeForGames)
            {
                int time1 = allTimesforGame - timeForGames;
                int hours = time1 / 60;
                int minutes = time1 % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                int time1 = timeForGames - allTimesforGame;
                int hours = time1 / 60;
                int minutes = time1 % 60;

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
