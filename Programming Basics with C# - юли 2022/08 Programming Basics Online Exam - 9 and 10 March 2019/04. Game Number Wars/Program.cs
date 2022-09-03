using System;

namespace _04._Game_Number_Wars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nameOfFirstPlayer = Console.ReadLine();
            string nameOfSecondPlayer = Console.ReadLine();

            int pointsOfPLayer1 = 0;
            int pointsOfPLayer2 = 0;

            string FirstPlayer = Console.ReadLine();
            string SecondPlayer = Console.ReadLine();


            while (FirstPlayer != "End of game")
            {
                int firstPlayerCard = int.Parse(FirstPlayer);
                int secondPlayerCard = int.Parse(SecondPlayer);

                if (firstPlayerCard == secondPlayerCard)
                {
                    FirstPlayer = Console.ReadLine();
                    SecondPlayer = Console.ReadLine();
                    firstPlayerCard = int.Parse(FirstPlayer);
                    secondPlayerCard = int.Parse(SecondPlayer);

                    if (firstPlayerCard > secondPlayerCard)
                    {
                        pointsOfPLayer1 = firstPlayerCard - secondPlayerCard;

                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{nameOfFirstPlayer} is winner with {pointsOfPLayer1} points");
                    }
                    else
                    {
                        pointsOfPLayer2 = secondPlayerCard - firstPlayerCard;
                        Console.WriteLine("Number wars!");
                        Console.WriteLine($"{secondPlayerCard} is winner with {pointsOfPLayer2} points");

                    }
                    break;
                }
                if (firstPlayerCard > secondPlayerCard)
                {
                    pointsOfPLayer1 += firstPlayerCard - secondPlayerCard;

                }
                else
                {
                    pointsOfPLayer2 += secondPlayerCard - firstPlayerCard;
                }




                FirstPlayer = Console.ReadLine();
                SecondPlayer = Console.ReadLine();

                if (FirstPlayer == "End of game")
                {
                    Console.WriteLine($"{nameOfFirstPlayer} has {pointsOfPLayer1} points");
                    Console.WriteLine($"{nameOfSecondPlayer} has {pointsOfPLayer2} points");
                    break;
                }
            }




        }
    }
}
