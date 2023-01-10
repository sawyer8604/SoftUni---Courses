using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArguments = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string firstCommand = cmdArguments[0];
                string carNumber = cmdArguments[1];

                if(firstCommand == "IN")
                {
                    cars.Add(carNumber);
                }
                else if(firstCommand == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }

            if(!cars.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
