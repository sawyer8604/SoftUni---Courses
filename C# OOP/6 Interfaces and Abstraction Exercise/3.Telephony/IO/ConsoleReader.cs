namespace _3.Telephony.IO
{
    using _3.Telephony.IO.Interfaces;
    using System;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        => Console.ReadLine();
    }
}
