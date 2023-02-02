using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Meal_Plan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mealsList = new Dictionary<string, int>();

            mealsList.Add("salad", 350);
            mealsList.Add("soup", 490);
            mealsList.Add("pasta", 680);
            mealsList.Add("steak", 790);

            string[] melas = Console.ReadLine().Split(" ");

            Queue<string> mealsQueue = new Queue<string>(melas);

            int[] calories = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> caloriesStack = new Stack<int>(calories);
            
            int mealsCounter = 0;
            while (true)
            {                
                if (!mealsQueue.Any())
                {
                    break;
                }
                if (!caloriesStack.Any())
                {
                    break;
                }

                string crrMeal = mealsQueue.Dequeue();

                int crrCalories = caloriesStack.Pop();
                mealsCounter++;

                if (crrCalories - mealsList[crrMeal] >= 0)
                {
                    crrCalories -= mealsList[crrMeal];

                    if (crrCalories > 0)
                    {
                        caloriesStack.Push(crrCalories);
                    }
                }
                else
                {
                    int crrMealCalories = mealsList[crrMeal];

                    if (caloriesStack.Count > 0)
                    {
                        crrCalories += caloriesStack.Pop();
                        crrCalories -= crrMealCalories;
                        if (crrCalories > 0)
                        {
                            caloriesStack.Push(crrCalories);
                        }
                    }
                }               

            }

            if(!mealsQueue.Any())
            {
                Console.WriteLine($"John had {mealsCounter} meals.");

                Console.WriteLine($"For the next few days, he can eat {string.Join(", ", caloriesStack)} calories.");
            }
            else
            {
                Console.WriteLine($"John ate enough, he had {mealsCounter} meals.");
                Console.WriteLine($"Meals left: {string.Join(", ", mealsQueue)}.");
            }

        }
    }
}
