using System;
using System.Linq;

namespace _02._The_Lift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWaitingPeople = int.Parse(Console.ReadLine());

            int[] liftState = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < liftState.Length; i++)
            {
                int crrPeople = liftState[i];

                while (true)
                {
                    if (numberOfWaitingPeople <= 0)
                    {
                        break;
                    }

                    if (crrPeople == 4)
                    {
                        break;
                    }
                    else
                    {
                        crrPeople++;
                        numberOfWaitingPeople--;
                    }
                }
                liftState[i] = crrPeople;

                if (crrPeople >= 4)
                {
                    continue;
                }


            }
            int maxSum = 4 * liftState.Length;

            int currentSum = liftState.Sum();



            if (numberOfWaitingPeople != 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfWaitingPeople} people in a queue!");
                Console.WriteLine(String.Join(" ", liftState));
            }
            else
            {
                if (maxSum > currentSum)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(String.Join(" ", liftState));
                }

                else
                {
                    Console.WriteLine(String.Join(" ", liftState));
                }
            }

        }
    }
}