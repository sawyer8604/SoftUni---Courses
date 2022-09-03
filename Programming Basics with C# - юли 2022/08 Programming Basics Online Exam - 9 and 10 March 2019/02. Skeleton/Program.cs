using System;

namespace _02._Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlMinutes = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            int secondsPer100Meters = int.Parse(Console.ReadLine());

            int controlaTimes = controlMinutes * 60 + controlSeconds;
            double numberOfReduction = length / 120 * 2.5;

            double allTime = (length / 100) * secondsPer100Meters - numberOfReduction;

            if(controlaTimes >= allTime)
            {
                Console.WriteLine($"Marin Bangiev won an Olympic quota!\r\nHis time is {allTime:f3}.");

            }
            else
            {

                Console.WriteLine($"No, Marin failed! He was {(allTime - controlaTimes):f3} second slower.");
            }
            
        }
    }
}
