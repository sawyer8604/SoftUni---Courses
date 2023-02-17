using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Climb_The_Peaks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Mountans> mountans = new List<Mountans>();
            mountans.Add(new Mountans("Vihren", 80));
            mountans.Add(new Mountans("Kutelo", 90));
            mountans.Add(new Mountans("Banski Suhodol", 100));
            mountans.Add(new Mountans("Polezhan", 60));
            mountans.Add(new Mountans("Kamenitza", 70));


            int[] portions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Stack<int> stackFood = new Stack<int>(portions);

            int[] stamina = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Queue<int> queueStamina = new Queue<int>(stamina);

            List<string> ConqueredPeaks = new List<string>();

            while (stackFood.Any() && queueStamina.Any() && mountans.Any())
            {
                foreach (var item in mountans)
                {
                    int crrFood = stackFood.Peek();
                    int crrStamina = queueStamina.Peek();
                    int sum = crrFood + crrStamina;

                    if (sum < item.Dificulty)
                    {
                        stackFood.Pop();
                        queueStamina.Dequeue();
                        break;
                    }

                    stackFood.Pop();
                    queueStamina.Dequeue();

                    ConqueredPeaks.Add(item.Name);

                    mountans.Remove(item);
                    break;
                }

            }

            if(!mountans.Any())
            {
                Console.WriteLine($"Alex did it! He climbed all top five Pirin peaks in one week -> @FIVEinAWEEK");
                
            }
            else
            {
                Console.WriteLine("Alex failed! He has to organize his journey better next time -> @PIRINWINS");
            }
            

            if(ConqueredPeaks.Any())
            {

                Console.WriteLine("Conquered peaks:");

                foreach (var peak in ConqueredPeaks)
                {
                    Console.WriteLine(peak);
                }
            }
        }
    }
    public class Mountans
    {
        public Mountans(string name, int dificulty)
        {
            Name = name;
            Dificulty = dificulty;
        }

        public string Name { get; set; }
        public int Dificulty { get; set; }
    }
}
