using System;

namespace _05_Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfPlayer;
            string bestPlayer = string.Empty;
            int maxGoal = 0;


            while ((nameOfPlayer = Console.ReadLine()) != "END")
            {


                int numberOfGoals = int.Parse(Console.ReadLine());

                if (numberOfGoals > maxGoal)
                {

                    bestPlayer = nameOfPlayer;
                    maxGoal = numberOfGoals;
                }

                if (numberOfGoals >= 10)
                {
                    break;
                }





            }


            Console.WriteLine($"{bestPlayer} is the best player!");

            if (maxGoal >= 3)
            {

                Console.WriteLine($"He has scored {maxGoal} goals and made a hat-trick !!!");

            }
            else
            {

                Console.WriteLine($"He has scored {maxGoal} goals.");
            }


        }


    }
}
