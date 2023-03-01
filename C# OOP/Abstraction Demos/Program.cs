using System;
using System.Text;

namespace Abstraction_Demos
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            RombusAsStringDrawer rombusAsStringDrawer = new RombusAsStringDrawer();
            string result = rombusAsStringDrawer.Draw(n);
            Console.WriteLine(result);

            
        }
       
    }
}
