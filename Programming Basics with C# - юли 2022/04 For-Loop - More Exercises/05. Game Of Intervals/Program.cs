using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double result = 0;
            double percent1 = 0;
            double percent2 = 0;
            double percent3 = 0;
            double percent4 = 0;
            double percent5 = 0;
            double percent6 = 0;
            double allPercent1 = 0;
            double allPercent2 = 0;
            double allPercent3 = 0;
            double allPercent4 = 0;
            double allPercent5 = 0;
            double allPercent6 = 0;



            for (int number = 0; number < moves; number++)
            {
                int numberForMoves = int.Parse(Console.ReadLine());



                if (numberForMoves >= 0 && numberForMoves <= 9)
                {
                    percent1++;
                    result += 0.2 * numberForMoves;
                }
                else if (numberForMoves >= 10 && numberForMoves <= 19)
                {
                    percent2++;
                    result += 0.3 * numberForMoves;
                }
                else if (numberForMoves >= 20 && numberForMoves <= 29)
                {
                    percent3++;
                    result += 0.4 * numberForMoves;
                }
                else if (numberForMoves >= 30 && numberForMoves <= 39)
                {
                    percent4++;
                    result += 50;


                }
                else if (numberForMoves >= 40 && numberForMoves <= 50)
                {
                    percent5++;
                    result += 100;


                }
                else if (numberForMoves < 0 || numberForMoves > 50)
                {
                    percent6++;
                    result /= 2;
                }
            }


            allPercent1 = percent1 / moves * 100;
            allPercent2 = percent2 / moves * 100;
            allPercent3 = percent3 / moves * 100;
            allPercent4 = percent4 / moves * 100;
            allPercent5 = percent5 / moves * 100;
            allPercent6 = percent6 / moves * 100;

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {allPercent1:f2}%");
            Console.WriteLine($"From 10 to 19: {allPercent2:f2}%");
            Console.WriteLine($"From 20 to 29: {allPercent3:f2}%");
            Console.WriteLine($"From 30 to 39: {allPercent4:f2}%");
            Console.WriteLine($"From 40 to 50: {allPercent5:f2}%");
            Console.WriteLine($"Invalid numbers: {allPercent6:f2}%");


        }
    }
}
