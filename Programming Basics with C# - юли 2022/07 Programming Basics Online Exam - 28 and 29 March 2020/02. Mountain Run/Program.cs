using System;

namespace _02._Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeFor1Meter = double.Parse(Console.ReadLine());

            double timeForClimbing = distance * timeFor1Meter;
            double timeDelayPer50Meters = Math.Floor(distance / 50) * 30;

            double allTime = timeForClimbing + timeDelayPer50Meters;

            if (allTime < recordInSeconds)
            {

                Console.WriteLine($"Yes! The new record is {allTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {(allTime - recordInSeconds):f2} seconds slower.");
            }
        }
    }
}
