using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат пет реда:
            //Първи ред – брой дни – цяло число в интервал[1…5000]
            //Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
            //Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
            //Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
            //Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]

            int numberOfDays = int.Parse(Console.ReadLine());
            int foods = int.Parse(Console.ReadLine());
            double foodForDog = double.Parse(Console.ReadLine());
            double foodForCat = double.Parse(Console.ReadLine());
            double foodForTurtleIngrams = double.Parse(Console.ReadLine());

            double FoodForTurtle = foodForTurtleIngrams / 1000;
            double allFoudsNeeded = (foodForDog + foodForCat + FoodForTurtle) * numberOfDays;

            double different = Math.Abs(foods - allFoudsNeeded);

            bool isallFoudsNeeded = allFoudsNeeded <= foods;

            if (isallFoudsNeeded)
            {
                Console.WriteLine($"{Math.Floor(different)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(different)} more kilos of food are needed.");
            }
        }
    }
}
