using System;
class HelloWorld
{
    static void Main()
    {
        string word = Console.ReadLine();

        while (word != "Stop")
        {
            Console.WriteLine(word);
            word = Console.ReadLine();

        }


    }
}