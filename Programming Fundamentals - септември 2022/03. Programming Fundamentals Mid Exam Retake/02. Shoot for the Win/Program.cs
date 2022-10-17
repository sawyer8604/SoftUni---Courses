using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command;

            int shootedTarget = 0;

            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);
                shootedTarget++;

                if (index < 0 || index >= number.Length)
                {
                    shootedTarget--;
                    continue;
                }
                int currElemet = number[index];
                number[index] = -1;

                for (int i = 0; i < number.Length; i++)
                {
                    if (number[i] == -1)
                    {
                        continue;
                    }
                    
                    if (number[i] > currElemet)
                    {
                        number[i] -= currElemet;
                        
                    }
                    else if(number[i] <= currElemet && number[i] != -1)
                    {
                        number[i] += currElemet;
                       
                    }
                }
            }

            Console.Write($"Shot targets: {shootedTarget} -> ");
            Console.WriteLine(String.Join(" ", number));

        }
    }
}
