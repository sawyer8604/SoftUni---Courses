using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            double foodQuantity = double.Parse(Console.ReadLine());
            int foodEatenDog = 0;
            int foodEatenCat = 0;
            double allEatenFood = 0;
            double totaleatenPerDay = 0;


            for (int i = 1; i <= numberOfDays; i++)
            {
                int eatenByDog = int.Parse(Console.ReadLine());
                int eatenByCat = int.Parse(Console.ReadLine());

                int eatenPerdayDog = eatenByDog;
                int eatenPerdayCat = eatenByCat;


                foodEatenDog += eatenByDog;
                foodEatenCat += eatenByCat;

                if (i % 3 == 0)
                {
                    totaleatenPerDay += (eatenPerdayDog + eatenPerdayCat) * 0.1;
                }
            }
            allEatenFood = foodEatenDog + foodEatenCat;
            double percentEatenFood = allEatenFood / foodQuantity * 100;
            double percentEatenDog = foodEatenDog / allEatenFood * 100;
            double percentEatenCat = foodEatenCat / allEatenFood * 100;

            Console.WriteLine($"Total eaten biscuits: {Math.Round(totaleatenPerDay)}gr.");
            Console.WriteLine($"{percentEatenFood:f2}% of the food has been eaten.");
            Console.WriteLine($"{percentEatenDog:f2}% eaten from the dog.");
            Console.WriteLine($"{percentEatenCat:f2}% eaten from the cat.");

        }
    }
}
