using System;
using System.Text.RegularExpressions;

namespace _2_SongEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Regex regex = new Regex(@"^[A-Z][a-z\' ]+\:[A-Z]+(\s?[A-Z]+)*\b");
            while ((input = Console.ReadLine()) != "end")
            {
                if (regex.IsMatch(input))
                {
                    string[] splitInput = input.Split(":");
                    string artist = splitInput[0];

                    char[] arrInput = input.ToCharArray();
                    for (int i = 0; i < arrInput.Length; i++)
                    {
                        int key = artist.Length;
                        if (char.IsLetter(arrInput[i]) && char.IsLower(arrInput[i]))
                        {
                            int symbol = arrInput[i];
                            while (key > 0)
                            {
                                symbol++;
                                key--;
                                if (symbol == 123)
                                {
                                    symbol = 97;
                                }

                            } //counter
                            arrInput[i] = (char)symbol;
                        }
                        else if (char.IsLetter(arrInput[i]) && char.IsUpper(arrInput[i]))
                        {
                            int symbol = arrInput[i];
                            while (key > 0)
                            {
                                symbol++;
                                key--;
                                if (symbol == 91)
                                {
                                    symbol = 65;
                                }

                            } //counter
                            arrInput[i] = (char)symbol;
                        }
                        else if (arrInput[i] == ':')
                        {
                            arrInput[i] = '@';
                        }

                    } // encrypt

                    Console.WriteLine($"Successful encryption: {string.Join("", arrInput)}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}