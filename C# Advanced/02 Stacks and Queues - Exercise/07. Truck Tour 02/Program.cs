using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPump = int.Parse(Console.ReadLine());

            Queue<Tour> queue = new Queue<Tour>();

            for (int i = 0; i < numberOfPetrolPump; i++)
            {
                int[] pumps = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                int petrol = pumps[0];
                int kilometres = pumps[1];


                queue.Enqueue(new Tour(petrol, kilometres));
            }
            int startIndex = 0;

            while (true)
            {
                int totalPetrol = 0;
                bool isTourEnd = true;

                foreach (var item in queue)
                {
                    int distance = item.Kilometres;
                    int petrol = item.Petrol;

                    totalPetrol += petrol;

                    if (totalPetrol - distance < 0)
                    {
                        startIndex++;
                        queue.Dequeue();
                        queue.Enqueue(new Tour(petrol, distance));

                        GC.Collect();

                        isTourEnd = false;
                        break;

                    }
                    totalPetrol -= distance;

                }
                
                if (isTourEnd)
                {
                    Console.WriteLine(startIndex);
                    break;
                }

            }

        }


    }
    public class Tour
    {
        public Tour(int petrol, int kilometres)
        {
            Petrol = petrol;
            Kilometres = kilometres;

        }

        public int Petrol { get; set; }
        public int Kilometres { get; set; }

    }
}
