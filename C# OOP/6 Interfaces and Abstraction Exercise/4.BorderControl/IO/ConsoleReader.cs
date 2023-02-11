namespace BorderControl.IO
{
    using BorderControl.IO.Interfeces;
    using System;

    public class ConsoleReader : IReader
    {
        public string ReadLine()
        => Console.ReadLine();
    }
}
