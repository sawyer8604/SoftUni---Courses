using System;

namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> printName = (name)
                => Console.WriteLine(name);

            printName("mus");

            Predicate<int> isEven = x
                => x % 2 == 0;

            bool isNumberEven = isEven(4);
            Console.WriteLine(isNumberEven);

            Func<int, int, int> sumOfNumbers = (x, y)
                => x + y;

            int sum = sumOfNumbers(2, 3);
            Console.WriteLine(sum);

        }
    }
}
