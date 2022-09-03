using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfMens = int.Parse(Console.ReadLine());
            int numberOfWomens = int.Parse(Console.ReadLine());
            int numberOfTables = int.Parse(Console.ReadLine());

            int counter = 0;

            while (counter <= numberOfTables)
            {

                for (int i = 1; i <= numberOfMens; i++)
                {


                    for (int j = 1; j <= numberOfWomens; j++)
                    {

                        if (counter >= numberOfTables)
                        {
                            return;
                        }
                        counter++;

                        Console.Write($"({i} <-> {j}) ");
                    }

                }
                if (counter >= numberOfMens || counter >= numberOfWomens)
                {
                    break;
                }
            }
        }
    }
}
