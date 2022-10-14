
namespace _06._Cards_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> secondPlayerCards = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            

            SumOfWinningPlayer(firstPlayerCards, secondPlayerCards);
        }

        private static void SumOfWinningPlayer(List<int> firstPlayerCards, List<int> secondPlayerCards)
        {
            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.Add(secondPlayerCards[0]);

                }
                else if (firstPlayerCards[0] < secondPlayerCards[0])
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.Add(firstPlayerCards[0]);
                                       
                }
                
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                


            }

            if (firstPlayerCards.Count > 0)
            {
                int sum = firstPlayerCards.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = secondPlayerCards.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
