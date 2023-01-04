using _01._ListyIterator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Collection
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            ListyIterator<string> listIterator = new ListyIterator<string>(input);


            string commands;

            while ((commands = Console.ReadLine()) != "END")
            {

                switch (commands)
                {
                    case "Move":

                        Console.WriteLine(listIterator.move());

                        break;

                    case "HasNext":

                        Console.WriteLine(listIterator.HasNext());

                        break;

                    case "Print":
                        try
                        {
                            listIterator.Print();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception.Message);

                        }

                        break;

                    case "PrintAll":
                        foreach (var item in listIterator)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();
                        break;

                }
            }
        }
    }
}
