using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            BigInteger biggestSnowBall = int.MinValue;
            string bestResult ="";

            for (int i = 0; i < number; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (biggestSnowBall <= snowballValue)
                {
                    biggestSnowBall = snowballValue;
                    bestResult = $"{snowballSnow} : {snowballTime} = {biggestSnowBall} ({snowballQuality})";

                }

            }
            Console.WriteLine(bestResult);


        }
    }
}
