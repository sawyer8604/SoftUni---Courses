using System;

namespace _01._Generic_Box_of_String
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();

                box.Items.Add(input);
            }
            Console.WriteLine(box.ToString());
        }
    }
}
