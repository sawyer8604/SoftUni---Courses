using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLights = int.Parse(Console.ReadLine());

            int freeWindows = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            bool isPassed = true;

            int passedCar = 0;

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                int crrGreenLight = greenLights;

                if (input == "green")
                {
                    while (crrGreenLight > 0 && queue.Any())
                    {

                        string crrCar = queue.Dequeue();

                        if (crrGreenLight - crrCar.Length >= 0)
                        {
                            crrGreenLight -= crrCar.Length;

                            passedCar++;

                            continue;
                        }


                        if (crrGreenLight + freeWindows >= crrCar.Length)
                        {
                            passedCar++;

                            crrGreenLight = 0;

                            continue;
                        }

                        isPassed = false;

                        Console.WriteLine("A crash happened!");

                        Console.WriteLine($"{crrCar} was hit at {crrCar[crrGreenLight + freeWindows]}.");

                        return;


                    }

                }
                else
                {
                    queue.Enqueue(input);
                }

            }

            if (isPassed)
            {
                Console.WriteLine("Everyone is safe.");

                Console.WriteLine($"{passedCar} total cars passed the crossroads.");
            }
        }
    }
}
