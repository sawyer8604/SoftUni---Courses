using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<name>[A-Z]{1}[a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>[0-9]+)\|[^|$%.]*?(?<price>\d+.*\d+)\$";
            string input;

            double totalPrice = 0;
            double sum = 0;


            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if(match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    totalPrice = count * price;
                    sum+=totalPrice;

                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");

                }


            }
            Console.WriteLine($"Total income: {sum:f2}");
        }
    }
}
