using System;

namespace _01._Guinea_Pig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double foodKilos = double.Parse(Console.ReadLine()) * 1000;
            double hayInKilos = double.Parse(Console.ReadLine()) * 1000;
            double coverKilos = double.Parse(Console.ReadLine()) * 1000;

            double weightKilos = double.Parse(Console.ReadLine()) * 1000;

            bool isFoodEnought = true;

            for (int i = 1; i <= 30; i++)
            {
                foodKilos -= 300;
                if(i % 2 == 0)
                {
                    hayInKilos -= foodKilos * 0.05;
                }

                if(i % 3 == 0)
                {
                    coverKilos -= (weightKilos / 3);
                }
                

                if(foodKilos <=0 || coverKilos <= 0 || hayInKilos <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    isFoodEnought = false;
                    break;
                }

            }

            if(isFoodEnought)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodKilos/1000):f2}, Hay: {(hayInKilos/1000):f2}, Cover: {(coverKilos/1000):f2}.");
            }

        }
    }
}
