using System;
class HelloWorld
{
    static void Main()
    {

        string name = Console.ReadLine();
        string password = Console.ReadLine();

        string input = Console.ReadLine();

        while (input != password)
        {
            input = Console.ReadLine();

        }

        Console.WriteLine($"Welcome {name}!");


    }
}