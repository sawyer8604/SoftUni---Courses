using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Collection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Skip(1)
               .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(input);

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (command == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if (command == "Print")
                {
                    try
                    {
                        Console.WriteLine(listyIterator.Print());
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else if(command == "PrintAll")
                {
                    foreach (var item in listyIterator)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
