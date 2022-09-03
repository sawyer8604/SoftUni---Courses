using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodForDog = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int FoodInGrams = foodForDog * 1000;
            int allEatenFoods = 0;

            while (input != "Adopted")
            {
                int command = int.Parse(input);

                allEatenFoods += command;


                input = Console.ReadLine();

            }
            if (allEatenFoods <= FoodInGrams)
            {

                Console.WriteLine($"Food is enough! Leftovers: {FoodInGrams - allEatenFoods} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {allEatenFoods - FoodInGrams} grams more.");
            }

        }
    }
}
