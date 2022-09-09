using System;
using System.ComponentModel;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fielddSize = int.Parse(Console.ReadLine());

            int[] ladyBugField = new int[fielddSize];

            string[] occupiedIndexses = Console.ReadLine().Split();

            for (int i = 0; i < occupiedIndexses.Length; i++)
            {
                int currentIndex = int.Parse(occupiedIndexses[i]);

                if (currentIndex >= 0 && currentIndex < fielddSize)
                {

                    ladyBugField[currentIndex] = 1;
                }
                    

            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                bool isFirst = true;
                int currentIndex = int.Parse(commands[0]);

                while (currentIndex >= 0 && currentIndex < fielddSize && ladyBugField[currentIndex] != 0)
                {
                    if(isFirst)
                    {

                        ladyBugField[currentIndex] = 0;
                        isFirst = false;
                    }

                    string dirrection = commands[1];
                    int flightLength = int.Parse(commands[2]);

                    if (dirrection == "left")
                    {
                        currentIndex -= flightLength;
                        if(currentIndex >= 0 && currentIndex < fielddSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                        }

                    }

                    else
                    {
                        currentIndex += flightLength;
                        if(currentIndex >= 0 && currentIndex < fielddSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }

                        }

                    }


                }

                commands = Console.ReadLine().Split();

            }

            Console.WriteLine(String.Join(" ", ladyBugField));

        }
    }
}
