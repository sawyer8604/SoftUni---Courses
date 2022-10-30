using System;
using System.Collections.Generic;

namespace _03._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> orders = new Dictionary<string, double>();

            Dictionary<string, int> newOrders = new Dictionary<string, int>();


            string commands;
            

            while ((commands = Console.ReadLine()) != "buy")
            {
                string[] cmdArguments = commands.Split();

                string name = cmdArguments[0];

                double price = double.Parse(cmdArguments[1]);

                int quantity = int.Parse(cmdArguments[2]);
                                

                if(!orders.ContainsKey(name))
                {
                    orders.Add(name, price);
                    newOrders.Add(name, 0);

                }
                else
                {
                    orders.Remove(name);
                    orders.Add(name, price);
                }

                newOrders[name] += quantity;
            }

            foreach (var item in orders)
            {

                foreach (var newitem in newOrders)
                {
                    if(item.Key == newitem.Key)
                    {

                        Console.WriteLine($"{item.Key} -> {(item.Value * newitem.Value):f2}");
                    }
                }

            }

        }
    }
}
