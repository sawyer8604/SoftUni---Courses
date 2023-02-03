using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings st= new StackOfStrings();

            List<string> values = new List<string>{"1", "2", "3" };

            Console.WriteLine(st.IsEmpty());

            st.AddRange(values);

            Console.WriteLine(st.IsEmpty());

            Console.WriteLine(string.Join(" ", st));
        }
    }
}
