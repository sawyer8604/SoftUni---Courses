namespace FoodShortage.IO
{
    using IO.Interfaces;
    using System;
   
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        => Console.Write(text);
        public void WriteLine(int text)
         => Console.WriteLine(text);
    }
}
