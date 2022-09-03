using System;
public class HelloWorld
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());

        int counter = 0;
        double avarage = 0;
        int allNumber = 0;

        while (counter < n)
        {

            int number = int.Parse(Console.ReadLine());

            allNumber += number;
            counter++;


        }
        avarage = 1.0 * allNumber / n;
        Console.WriteLine($"{avarage:f2}");

    }
}
