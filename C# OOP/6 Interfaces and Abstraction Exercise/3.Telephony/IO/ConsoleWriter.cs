
namespace _3.Telephony.IO
{
    using IO.Interfaces;
    using System;
   
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
       => Console.Write(text);

        public void WriteLn(string text)
        => Console.WriteLine(text);
    }
}
