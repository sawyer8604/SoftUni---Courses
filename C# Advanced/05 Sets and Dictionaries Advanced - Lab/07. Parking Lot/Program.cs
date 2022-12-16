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
                string[] cmdArguments = command.Split(", ");

                string fisrtCommand = cmdArguments[0];
                string carNumber = cmdArguments[1];

                if (fisrtCommand == "IN")
                {
                    cars.Add(carNumber);

                }
                else if(fisrtCommand == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }

            if(cars.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
