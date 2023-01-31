using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Climb_The_Peaks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mountains = new Dictionary<string, int>();

            mountains.Add("Vihren", 80);
            mountains.Add("Kutelo", 90);
            mountains.Add("Banski Suhodol", 100);
            mountains.Add("Polezhan", 60);
            mountains.Add("Kamenitza", 70);

            int count = mountains.Count();

            int[] food = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Stack<int> foodStack = new Stack<int>(food);

            int[] stamina = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> stamninaQueue = new Queue<int>(stamina);

            HashSet<string> conquered = new HashSet<string>();

            while (foodStack.Any() && stamninaQueue.Any() && mountains.Any())
            {
                foreach (var (name, dificulty) in mountains)
                {

                    int crrFood = foodStack.Pop();
                    int crrStamnina = stamninaQueue.Dequeue();
                    int sum = crrFood + crrStamnina;

                    if (dificulty > sum)
                    {
                        break;
                    }

                    conquered.Add(name);
                    mountains.Remove(name);

                }

            }

            if (conquered.Count == count)
            {
                Console.WriteLine($"Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");

            }
            else
            {
                Console.WriteLine($"Alex failed! He has to organize his journey better next time -> @PIRINWINS");

            }

            if (conquered.Any())
            {
                Console.WriteLine("Conquered peaks:");
                Console.WriteLine(string.Join(Environment.NewLine, conquered));
            }
        }
    }
}