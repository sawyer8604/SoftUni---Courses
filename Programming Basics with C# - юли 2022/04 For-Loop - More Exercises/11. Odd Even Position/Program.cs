using System;

namespace _11._Odd__Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;

            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;


            for (int number = 1; number <= n; number++)
            {

                double curentNumber = double.Parse(Console.ReadLine());



                if (number % 2 == 0)
                {
                    EvenSum += curentNumber;
                    if (curentNumber != 0)
                    {
                        if (curentNumber > EvenMax)
                        {
                            EvenMax = curentNumber;

                        }
                        if (curentNumber < EvenMin)
                        {
                            EvenMin = curentNumber;
                        }

                    }


                }

                else
                {
                    OddSum += curentNumber;

                    if (curentNumber != 0)
                    {
                        if (curentNumber > OddMax)
                        {
                            OddMax = curentNumber;

                        }
                        if (curentNumber < OddMin)
                        {
                            OddMin = curentNumber;
                        }

                    }


                }


            }
            Console.WriteLine($"OddSum={OddSum:f2},");

            if (OddMin == double.MaxValue)
            {
                Console.WriteLine("OddMin=No,");

            }
            else
            {
                Console.WriteLine($"OddMin={OddMin:f2},");

            }

            if (OddMax == double.MinValue)
            {
                Console.WriteLine("OddMax=No,");
            }
            else
            {

                Console.WriteLine($"OddMax={OddMax:f2},");
            }
            Console.WriteLine($"EvenSum={EvenSum:f2},");



            if (EvenMin == double.MaxValue)
            {
                Console.WriteLine("EvenMin=No,");

            }
            else
            {
                Console.WriteLine($"EvenMin={EvenMin:f2},");

            }

            if (EvenMax == double.MinValue)
            {
                Console.WriteLine("EvenMax=No");
            }
            else
            {

                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }

        }


    }
}
