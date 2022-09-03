using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]

            //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]

            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeterr = double.Parse(Console.ReadLine());
            double timeInSecondsForMeter = double.Parse(Console.ReadLine());

            double waterResistents = Math.Floor(distanceInMeterr / 15);
            double timeWithResistant = waterResistents * 12.5;

            double timeForSwim = distanceInMeterr * timeInSecondsForMeter + timeWithResistant;

            double diferrence = Math.Abs(recordInSeconds - timeForSwim);

            if (timeForSwim < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeForSwim:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {diferrence:f2} seconds slower.");
            }



        }
    }
}
