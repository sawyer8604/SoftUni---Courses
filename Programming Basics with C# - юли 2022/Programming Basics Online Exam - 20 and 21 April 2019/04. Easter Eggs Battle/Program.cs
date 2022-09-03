using System;

namespace _04._Easter_Eggs_Battle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEgssPlayer1 = int.Parse(Console.ReadLine());
            int numberOfEgssPlayer2 = int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();

            while (winner != "End")
            {
                if (winner == "one")
                {
                    numberOfEgssPlayer2--;
                }
                else if (winner == "two")
                {
                    numberOfEgssPlayer1--;
                }

                if (numberOfEgssPlayer1 <= 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {numberOfEgssPlayer2} eggs left.");
                    return;
                }
                if (numberOfEgssPlayer2 <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {numberOfEgssPlayer1} eggs left.");
                    return;
                }


                winner = Console.ReadLine();
            }


            Console.WriteLine($"Player one has {numberOfEgssPlayer1} eggs left.");
            Console.WriteLine($"Player two has {numberOfEgssPlayer2} eggs left.");

        }
    }
}
