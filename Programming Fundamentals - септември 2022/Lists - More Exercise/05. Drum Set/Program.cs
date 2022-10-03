using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double savingMoney = double.Parse(Console.ReadLine());

            List<int> quality = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> originalQuality = new List<int>();

            string command = Console.ReadLine();

            for (int i = 0; i < quality.Count; i++)
            {
                originalQuality.Add(quality[i]);
            }

            while (command != "Hit it again, Gabsy!")
            {

                int input = int.Parse(command);


                for (int i = 0; i < quality.Count; i++)
                {

                    quality[i] -= input;

                    if (quality[i] <= 0)
                    {
                        if (savingMoney - originalQuality[i] * 3 >= 0)
                        {
                            savingMoney = savingMoney - originalQuality[i] * 3;
                            quality[i] = originalQuality[i];
                        }

                    }

                }
                for (int i = 0; i < originalQuality.Count; i++)
                {
                    if (quality[i] <= 0)
                    {
                        quality.Remove(quality[i]);
                        originalQuality.Remove(originalQuality[i]);
                    }
                }

                command = Console.ReadLine();
            }
            

            Console.WriteLine(String.Join(" ", quality));
            Console.WriteLine($"Gabsy has {savingMoney:f2}lv.");
        }
    }
}
