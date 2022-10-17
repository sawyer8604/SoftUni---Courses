using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            
            string command = Console.ReadLine();
            int counter = 0;
            bool isEneregyLeft = true;

            do
            {                
                int distance = int.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {counter} won battles and {energy} energy");
                    isEneregyLeft = false;
                    break;
                }
                counter++;

                energy -= distance;

                if (counter % 3 == 0)
                {
                    energy += counter;

                }

            } while ((command = Console.ReadLine()) != "End of battle");
                        
            if(isEneregyLeft)
            {
                Console.WriteLine($"Won battles: {counter}. Energy left: {energy}");
            }
        }
    }
}
