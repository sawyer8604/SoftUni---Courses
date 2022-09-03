using System;
class _06_Cake

{
    static void Main()
    {
        int width = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());

        int allPices = width * length;
        int pices = 0;

        while (pices < allPices)
        {
            string input = Console.ReadLine();

            if (input == "STOP")
            {
                Console.WriteLine($"{allPices - pices} pieces are left.");
                break;
            }

            pices += int.Parse(input);

            if (pices > allPices)
            {
                Console.WriteLine($"No more cake left! You need {pices - allPices} pieces more.");

            }


        }

    }
}