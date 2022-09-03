using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();


            while (destination != "End")
            {
                double needetMoney = double.Parse(Console.ReadLine());
                double savedmoney = 0;
                double currentMoney = 0;

                while (needetMoney > savedmoney)
                {
                    currentMoney = double.Parse(Console.ReadLine());


                    savedmoney += currentMoney;
                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();

            }

        }
    }
}
