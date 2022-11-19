using System;
using System.Collections.Generic;

namespace _03._A_Miner_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            string resource;

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if(!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;
            }

            foreach (var (resourc, quantity) in resources)
            {
                Console.WriteLine($"{resourc} -> {quantity}");
            }
        }
    }
}
