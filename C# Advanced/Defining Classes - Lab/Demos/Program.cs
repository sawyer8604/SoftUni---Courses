using System;

namespace Demos
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            Car bmw = new Car();
            {
                bmw.Name = "3";
                bmw.Company = "bmw";

            };


            bmw.Drive(33);
            bmw.Drive(15);

            Car audi = new Car();
            {
                bmw.Name = "a4";
                bmw.Company = "audi";

            };



        }
    }

    
}
