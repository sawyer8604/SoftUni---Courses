using _05.BirthdayCelebrations.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        => Console.ReadLine();
    }
}
