using System;
using System.Text;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] codes = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < codes.Length; i++)
            {
                string currWord = codes[i];

                string[] symbols = currWord.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                foreach (string symbol in symbols)
                {
                    string crrSymbol = string.Empty;

                    switch (symbol)
                    {
                        case ".-":
                            crrSymbol = "A";

                            break;
                        case "-...":

                            crrSymbol = "B";

                            break;
                        case "-.-.":

                            crrSymbol = "C";
                            break;

                        case "-..":

                            crrSymbol = "D";
                            break;

                        case ".":

                            crrSymbol = "E";
                            break;

                        case "..-.":

                            crrSymbol = "F";
                            break;

                        case "--.":

                            crrSymbol = "G";
                            break;

                        case "....":

                            crrSymbol = "H";
                            break;

                        case "..":

                            crrSymbol = "I";
                            break;

                        case ".---":

                            crrSymbol = "J";
                            break;

                        case "-.-":

                            crrSymbol = "K";
                            break;

                        case ".-..":

                            crrSymbol = "L";
                            break;

                        case "--":

                            crrSymbol = "M";
                            break;

                        case "-.":

                            crrSymbol = "N";
                            break;

                        case "---":

                            crrSymbol = "O";
                            break;

                        case ".--.":

                            crrSymbol = "P";
                            break;

                        case "--.-":

                            crrSymbol = "Q";
                            break;

                        case ".-.":

                            crrSymbol = "R";
                            break;

                        case "...":

                            crrSymbol = "S";
                            break;

                        case "-":

                            crrSymbol = "T";
                            break;

                        case "..-":

                            crrSymbol = "U";
                            break;

                        case "...-":

                            crrSymbol = "V";
                            break;

                        case ".--":

                            crrSymbol = "W";
                            break;

                        case "-..-":

                            crrSymbol = "X";
                            break;

                        case "-.--":

                            crrSymbol = "Y";
                            break;

                        case "--..":

                            crrSymbol = "Z";
                            break;
                    }

                    sb.Append(crrSymbol);
                }
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
