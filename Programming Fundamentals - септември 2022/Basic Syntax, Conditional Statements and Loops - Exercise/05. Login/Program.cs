using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            int usernameLength = username.Length-1;
            string password = string.Empty;

            for (int i = usernameLength; i >= 0; i--)
            {
                password += username[i];

            }

            int passwordCounter = 0;

            while (passwordCounter != 3)
            {
                passwordCounter++;

                string userPassword = Console.ReadLine();

                if (userPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
            Console.WriteLine($"User {username} blocked!");

            

        }
    }
}
