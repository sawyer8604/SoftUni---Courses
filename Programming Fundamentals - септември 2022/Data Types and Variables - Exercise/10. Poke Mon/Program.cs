using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int counter = 0;
            int powerCopy = power;

            while (power >= distance)
            {
                counter++;
                power -= distance;

                if (power == powerCopy*0.5 && exhaustion >0)
                {
                    power /= exhaustion;
                }

            }
            Console.WriteLine(power);
            Console.WriteLine(counter);

        }
    }
}
