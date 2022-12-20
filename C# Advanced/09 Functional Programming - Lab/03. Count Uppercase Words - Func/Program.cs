using System;
using System.Linq;

namespace _03._Count_Uppercase_Words___Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> isStringBeginWithCapital = w => char.IsUpper(w[0]);

            input = input.Where(isStringBeginWithCapital).ToArray();

           // input = input.Where(w => char.IsUpper(w[0])).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
