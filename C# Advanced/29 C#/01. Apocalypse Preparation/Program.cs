using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> medics = new Dictionary<string, int>();

            medics.Add("Patch", 30);
            medics.Add("Bandage", 40);
            medics.Add("MedKit", 100);    

            int[] textiles = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queueTextiles = new Queue<int>(textiles);

            int[] medicaments = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Stack<int> stackMedicaments = new Stack<int>(medicaments);

            Dictionary<string, int> result = new Dictionary<string, int>(); 

            while (queueTextiles.Any() && stackMedicaments.Any())
            {
                bool isExist = false;

                int crrTextile = queueTextiles.Peek();
                int crrMedicament = stackMedicaments.Peek();
                int sum = crrMedicament + crrTextile;

                foreach (var item in medics)
                {
                    if(sum == item.Value)
                    {
                        if(!result.ContainsKey(item.Key))
                        {
                            result[item.Key] = 0;
                        }

                        result[item.Key]++;

                        queueTextiles.Dequeue();
                        stackMedicaments.Pop();

                        isExist = true;
                    }
                }

                if(isExist)
                {
                    continue;
                }

                if(sum > medics["MedKit"])
                {
                    if(!result.ContainsKey("MedKit"))
                    {
                        result["MedKit"] = 0;
                    }
                    result["MedKit"]++;
                    int crrResult = sum - medics["MedKit"];
                    queueTextiles.Dequeue();
                    stackMedicaments.Pop();

                    if(stackMedicaments.Any())
                    {
                        int crrElement = stackMedicaments.Pop() + crrResult;
                        stackMedicaments.Push(crrElement);

                    }                    

                    continue;
                }
                queueTextiles.Dequeue();
                int crrElements = stackMedicaments.Pop() + 10;
                stackMedicaments.Push(crrElements);

            }

            if(!queueTextiles.Any() && !stackMedicaments.Any())
            {
                Console.WriteLine("Textiles and medicaments are both empty.");
            }
            else if(!queueTextiles.Any())
            {
                Console.WriteLine("Textiles are empty.");
            }
            else if(!stackMedicaments.Any())
            {
                Console.WriteLine("Medicaments are empty.");
            }


            foreach (var (name, amount) in result.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{name} - {amount}");
            }

            if (stackMedicaments.Any())
            {
                Console.WriteLine($"Medicaments left: {string.Join(", ", stackMedicaments)}");
            }

            if (queueTextiles.Any())
            {
                Console.WriteLine($"Textiles left: {string.Join(", ", queueTextiles)}");
            }

        }
    }
        
}
