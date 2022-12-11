using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightTime = int.Parse(Console.ReadLine());

            int freeWindowsTime = int.Parse(Console.ReadLine());


            Queue<string> queue = new Queue<string>();

            string commands;
            int carCounter = 0;



            while ((commands = Console.ReadLine()) != "END")
            {
                if (commands == "green")
                {


                    int crrGreenLight = greenLightTime;

                    while (crrGreenLight > 0 && queue.Any())
                    {
                        string crrCar = queue.Dequeue();

                        if (crrGreenLight - crrCar.Length >= 0)
                        {
                            carCounter++;
                            crrGreenLight -= crrCar.Length;
                            continue;

                        }

                        if (crrGreenLight + freeWindowsTime - crrCar.Length >= 0)
                        {
                            crrGreenLight = 0;
                            carCounter++;
                            continue;

                        }

                        int hitIndex = crrGreenLight + freeWindowsTime;

                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{crrCar} was hit at {crrCar[hitIndex]}.");
                        return;


                    }
                }
                else
                {
                    queue.Enqueue(commands);
                }


            }


            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carCounter} total cars passed the crossroads.");


        }
    }
}
