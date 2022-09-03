using System;

namespace _02._Football_Results
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstGameResult = Console.ReadLine();
            string secondGameResult = Console.ReadLine();
            string thirdGameResult = Console.ReadLine();

            

            char firstLetterFromFirstWord = firstGameResult[0];
            char secondLetterFromFirstWord = firstGameResult[2];
            char firstLetterFromSecondWord = secondGameResult[0];
            char secondLetterFromSecondWord = secondGameResult[2];
            char firstLetterFromThirdWord = thirdGameResult[0];
            char secondLetterFromThirdWord = thirdGameResult[2];

            int win = 0;
            int lose = 0;
            int draw = 0;
            
            if (firstLetterFromFirstWord > secondLetterFromFirstWord)
            {
                win++;
                
            }
            else if ((firstLetterFromFirstWord < secondLetterFromFirstWord))
            {
                lose++;
            }
            else
            {
                draw++;
            }

            if (firstLetterFromSecondWord > secondLetterFromSecondWord)
            {
                win++;
                
            }
            else if (firstLetterFromSecondWord < secondLetterFromSecondWord)
            {
                lose++;
            }
            else
            {
                draw++;
            }

            if (firstLetterFromThirdWord > secondLetterFromThirdWord)
            {
                win++;
               
            }
            else if (firstLetterFromThirdWord < secondLetterFromThirdWord)
            {
                lose++;
            }
            else
            {
                draw++;
            }

            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lose} games.");
            Console.WriteLine($"Drawn games: {draw}");

        }
    }
}
