using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\%(?<name>[A-Z][a-z]+)\%[^\|\$\%\.]*?\<(?<product>\w+)\>[^\|\$\%\.]*?\|(?<count>[0-9]+)\|[^\|\$\%\.]*?(?<price>\d+(\.\d+)?)\$";

            string input;

            double totalMoney = 0;


            while ((input = Console.ReadLine()) != "end of shift")
            {
                Regex regex = new Regex(patern);

                Match match = regex.Match(input);
                double crrPrice = 0;

                if(match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    crrPrice = price * count;

                    totalMoney += crrPrice;

                    Console.WriteLine($"{name}: {product} - {crrPrice:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalMoney:f2}");

        }
    }
}
