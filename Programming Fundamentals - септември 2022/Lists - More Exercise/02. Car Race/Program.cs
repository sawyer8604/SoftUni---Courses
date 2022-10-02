using System;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrToRace = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double firstRacerSum = 0;
            double secondRacerSum = 0;
            string racer = string.Empty;

            for (int i = 0; i < arrToRace.Length/2; i++)
            {
                firstRacerSum += arrToRace[i];
                if(arrToRace[i] == 0)
                {
                    firstRacerSum *= 0.8;
                }
                

            }

            for (int i = arrToRace.Length - 1 ; i > arrToRace.Length / 2; i--)
            {
                secondRacerSum += arrToRace[i];
                if (arrToRace[i] == 0)
                {
                    secondRacerSum *= 0.8;
                }
                
            }

            if(firstRacerSum > secondRacerSum)
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
    }
}
