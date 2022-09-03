using System;
class _02_Cat_Walking
{
    static void Main()
    {

        int tripMinutes = int.Parse(Console.ReadLine());
        int numberOTrip = int.Parse(Console.ReadLine());
        int calories = int.Parse(Console.ReadLine());

        int caloriesBurn = 5 * tripMinutes * numberOTrip;

        if (caloriesBurn >= calories * 0.5)
        {

            Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {caloriesBurn}.");
        }
        else
        {

            Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {caloriesBurn}.");
        }
    }
}