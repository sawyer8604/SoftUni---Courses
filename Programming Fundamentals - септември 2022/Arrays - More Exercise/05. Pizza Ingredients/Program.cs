
namespace _05._Pizza_Ingredients
{
    using System;
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int searchedLenth = int.Parse(Console.ReadLine()); 

            while (true)
            {
                string allElements = string.Empty;
                int counter = 0;

                for (int i = 0; i < ingredients.Length; i++)
                {
                    string currentIngredient = ingredients[i];


                    if (currentIngredient.Length == searchedLenth)
                    {
                        counter++;
                        allElements += currentIngredient + ", ";
                        Console.WriteLine($"Adding {currentIngredient}.");

                    }

                }
                                

                int index = allElements.LastIndexOf(',');
                string newelements = allElements.Remove(index, 1);

                int space = newelements.LastIndexOf(' ');
                string newelements2 = newelements.Remove(space, 1);
                


                Console.WriteLine($"Made pizza with total of {counter} ingredients.");
                Console.WriteLine($"The ingredients are: {newelements2}.");

                if (counter >= 10)
                {
                    break;
                }


                ingredients = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                searchedLenth = int.Parse(Console.ReadLine());

            }
        }
    }
}
