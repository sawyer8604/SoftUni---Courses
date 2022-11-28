using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\@\#+(?<word>[A-Z]{1}[A-Za-z0-9]{4,}[A-Z]{1})\@\#+";

            int numberOflines = int.Parse(Console.ReadLine());

            Regex regex = new Regex(patern);

            for (int i = 0; i < numberOflines; i++)
            {
                string input = Console.ReadLine();

                Match match = regex.Match(input);

                if(match.Success)
                {
                   string word = match.Groups["word"].Value;

                    string crrLetter = "";

                    foreach (char ch in word)
                    {                        

                        if(char.IsDigit(ch))
                        {
                            crrLetter += ch;
                        }

                    }

                    if(crrLetter.Length > 0)
                    {
                        Console.WriteLine($"Product group: {crrLetter}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }                    

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }


        }
    }
}
