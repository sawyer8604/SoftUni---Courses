using _03.GenericScale;
using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equality = new EqualityScale<int>(2, 2);
            Console.WriteLine(equality.AreEqual());
        }
    }
}
