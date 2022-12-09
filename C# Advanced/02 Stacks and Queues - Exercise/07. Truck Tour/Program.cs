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

            Queue<int[]> queue = new Queue<int[]>();

            for (int i = 0; i < numberOfPetrolPump; i++)
            {
                int[] pumps = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                queue.Enqueue(pumps);
            }

            int startIndex = 0;

            while (true)
            {
                int totalPetrol = 0;
                bool isTourEnd = true;

                foreach (var item in queue)
                {
                   
                    int petrol = item[0];
                    int distance = item[1];

                    totalPetrol += petrol;

                    if (totalPetrol - distance < 0)
                    {
                        startIndex++;
                        int[] crrPump = queue.Dequeue();
                        queue.Enqueue(crrPump);
                        isTourEnd = false;
                        break;

                    }
                    totalPetrol -= distance;

                }

                if(isTourEnd)
                {
                    Console.WriteLine(startIndex);
                    break;
                }

            }


        }


    }
   
}

