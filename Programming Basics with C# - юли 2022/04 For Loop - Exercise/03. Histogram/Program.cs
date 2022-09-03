using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            double p1Numbers = 0;
            double p2Numbers = 0;
            double p3Numbers = 0;
            double p4Numbers = 0;
            double p5Numbers = 0;

            for (int i = 1; i <= number; i++)
            {
                int currentnumer = int.Parse(Console.ReadLine());

                if (currentnumer < 200)
                {
                    p1++;
                }
                else if (currentnumer >= 200 && currentnumer < 400)
                {
                    p2++;
                }
                else if (currentnumer >= 400 && currentnumer < 600)
                {
                    p3++;
                }
                else if (currentnumer >= 600 && currentnumer < 800)
                {
                    p4++;
                }
                else if (currentnumer >= 800)
                {
                    p5++;
                }


            }
            p1Numbers = p1 / number * 100;
            p2Numbers = p2 / number * 100;
            p3Numbers = p3 / number * 100;
            p4Numbers = p4 / number * 100;
            p5Numbers = p5 / number * 100;

            Console.WriteLine($"{p1Numbers:f2}%");
            Console.WriteLine($"{p2Numbers:f2}%");
            Console.WriteLine($"{p3Numbers:f2}%");
            Console.WriteLine($"{p4Numbers:f2}%");
            Console.WriteLine($"{p5Numbers:f2}%");

        }
    }
}
