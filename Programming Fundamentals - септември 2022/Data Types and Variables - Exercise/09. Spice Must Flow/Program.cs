using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());

            int counter = 0;
            
            int spiceLeft = 0;

            while (startingYield >= 100)
            {
                counter++;
                spiceLeft += startingYield -26;
                startingYield -= 10;

                if (startingYield < 100)
                {
                    spiceLeft -= 26;
                }
            }
            Console.WriteLine(counter);
            Console.WriteLine(spiceLeft);

        }
    }
}
