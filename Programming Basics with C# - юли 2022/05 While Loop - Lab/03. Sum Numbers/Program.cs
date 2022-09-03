using System;
class HelloWorld
{
    static void Main()

    {
        int number = int.Parse(Console.ReadLine());

        int sum = 0;

        while (sum < number)
        {

            int currentNumber = int.Parse(Console.ReadLine());
            sum += currentNumber;

            if (sum >= number)
            {
                Console.WriteLine(sum);
            }
        }


    }
}