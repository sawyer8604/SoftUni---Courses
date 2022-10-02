using System;
using System.Linq;

namespace _02._Car_Race_With_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arrToRace = Console.ReadLine().Split().Select(int.Parse).ToArray();

            
            
            string racer = string.Empty;

            double firstRacerSum = getLeftSum(arrToRace);
            double secondRacerSum = getRightSum(arrToRace);                      


            if (firstRacerSum > secondRacerSum)
            {
                racer = "right";
                Console.WriteLine($"The winner is {racer} with total time: {secondRacerSum}");
            }
            else
            {
                racer = "left";
                Console.WriteLine($"The winner is {racer} with total time: {firstRacerSum}");
            }

        }

        static double getLeftSum(int[] arrToRace)
        {
            double firstRacerSum = 0;
            for (int i = 0; i < arrToRace.Length / 2; i++)
            {
                firstRacerSum += arrToRace[i];
                if (arrToRace[i] == 0)
                {
                    firstRacerSum *= 0.8;
                }


            }
            return firstRacerSum;
        }

        static double getRightSum(int[] arrToRace)
        {
            double secondRacerSum = 0;

            for (int i = arrToRace.Length - 1; i > arrToRace.Length / 2; i--)
            {
                secondRacerSum += arrToRace[i];
                if (arrToRace[i] == 0)
                {
                    secondRacerSum *= 0.8;
                }

            }
            return secondRacerSum;
        }
    }
}
