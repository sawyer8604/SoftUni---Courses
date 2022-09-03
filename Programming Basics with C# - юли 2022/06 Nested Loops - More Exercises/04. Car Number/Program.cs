using System;

namespace _04._Car_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());


            for (int i = beginNumber; i <= endNumber; i++)
            {
                for (int j = beginNumber; j <= endNumber; j++)
                {
                    for (int k = beginNumber; k <= endNumber; k++)
                    {
                        for (int l = beginNumber; l <= endNumber; l++)
                        {
                            if (i % 2 == 0 && l % 2 != 0 && i > l && (j + k) % 2 == 0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");

                            }
                            else if (i % 2 != 0 && l % 2 == 0 && i > l && (j + k) % 2 == 0)
                            {

                                Console.Write($"{i}{j}{k}{l} ");
                            }



                        }
                    }
                }
            }
        }
    }
}
