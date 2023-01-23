using System;
using System.Linq;

namespace _05.GenericCountMethodString
{
    public class StartUp
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

            string element = Console.ReadLine();

            int countOfBiggerElements = box.CompareElements(element);           

            Console.WriteLine(countOfBiggerElements);
        }
    }
}
