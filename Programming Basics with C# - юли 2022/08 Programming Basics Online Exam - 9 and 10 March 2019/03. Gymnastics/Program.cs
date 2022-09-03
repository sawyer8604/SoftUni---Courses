using System;

namespace _03._Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country =Console.ReadLine();
            string instrument = Console.ReadLine();

            double dificulty = 0;
            double preformance = 0;

            switch (country)
            {
                case "Russia":
                    if (instrument == "ribbon")
                    {
                        dificulty = 9.100;
                        preformance = 9.4;

                    }
                    else if (instrument == "hoop")
                    {
                        dificulty = 9.300;
                        preformance = 9.8;

                    }
                    else if(instrument == "rope")
                    {
                        dificulty = 9.6;
                        preformance = 9.0;

                    }
                    break;

                    case "Bulgaria":

                    if (instrument == "ribbon")
                    {
                        dificulty = 9.600;
                        preformance = 9.4;

                    }
                    else if (instrument == "hoop")
                    {
                        dificulty = 9.550;
                        preformance = 9.75;

                    }
                    else if (instrument == "rope")
                    {
                        dificulty = 9.5;
                        preformance = 9.4;

                    }

                    break;


                    case "Italy":
                    if (instrument == "ribbon")
                    {
                        dificulty = 9.200;
                        preformance = 9.5;

                    }
                    else if (instrument == "hoop")
                    {
                        dificulty = 9.450;
                        preformance = 9.35;

                    }
                    else if (instrument == "rope")
                    {
                        dificulty = 9.7;
                        preformance = 9.15;

                    }

                    break;



            }

            double percent = 20 - (dificulty + preformance);
            percent = (percent / 20) * 100;

            Console.WriteLine($"The team of {country} get {(dificulty + preformance):f3} on {instrument}.");
            Console.WriteLine($"{percent:f2}%");
        }
    }
}
