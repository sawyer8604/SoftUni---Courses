using _01GenericBoxofString;
using System;

namespace _01._Generic_Box_of_String
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLine = int.Parse(Console.ReadLine());

            Box<string> box  = new Box<string>();

            for (int i = 0; i < numberOfLine; i++)
            {
                string input = Console.ReadLine();

                box.Items.Add(input);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
