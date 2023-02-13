using _05.BirthdayCelebrations.Core;
using _05.BirthdayCelebrations.Core.Interfaces;
using _05.BirthdayCelebrations.IO;
using _05.BirthdayCelebrations.IO.Interfaces;
using System;

namespace _05.BirthdayCelebrations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();
        }
    }
}
