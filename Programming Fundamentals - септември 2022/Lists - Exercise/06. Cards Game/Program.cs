using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCard = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCard = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (firstPlayerCard.Count > 0 && secondPlayerCard.Count > 0)
            {
                                
                if (firstPlayerCard[0] > secondPlayerCard[0])
                {
                    firstPlayerCard.Add(firstPlayerCard[0]);
                    firstPlayerCard.Add(secondPlayerCard[0]);                    
                        
                }
                else if(firstPlayerCard[0] < secondPlayerCard[0])
                {
                    secondPlayerCard.Add(secondPlayerCard[0]);
                    secondPlayerCard.Add(firstPlayerCard[0]);
                    
                }
                
                    firstPlayerCard.RemoveAt(0);
                    secondPlayerCard.RemoveAt(0);               

            }
            

            if(firstPlayerCard.Count > secondPlayerCard.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCard.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCard.Sum()}");

            }
        }
    }
}
