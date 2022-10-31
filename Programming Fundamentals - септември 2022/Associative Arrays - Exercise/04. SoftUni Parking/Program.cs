using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Dictionary<string, string> registerToCar = new Dictionary<string, string>();


            for (int i = 0; i < numberOfLines; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string registeredOrNot = commands[0];
                string username = commands[1];
                
                

                if (registeredOrNot == "register")
                {
                    string plateNumber = commands[2];

                    if (registerToCar.ContainsKey(username))
                    {
                        string licenseNumberRegistered = registerToCar[username];

                        Console.WriteLine($"ERROR: already registered with plate number {licenseNumberRegistered}");

                    }
                    else
                    {
                        registerToCar.Add(username, plateNumber);

                        Console.WriteLine($"{username} registered {plateNumber} successfully");
                        
                    }

                }
                else if(registeredOrNot == "unregister")
                {
                    if(!registerToCar.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        registerToCar.Remove(username);
                    }
                }

                
            }

            foreach (var car in registerToCar)
            {
                string user = car.Key;
                string carNumber = car.Value;

                Console.WriteLine($"{user} => {carNumber}");

            }
        }
    }
}
