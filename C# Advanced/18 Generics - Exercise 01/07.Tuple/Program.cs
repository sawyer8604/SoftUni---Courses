using System;
using System.Linq;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] fulNameAndAdress = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string fulname = fulNameAndAdress[0]+ " " + fulNameAndAdress[1];
            string adress = fulNameAndAdress[2];

            MyTuple<string, string> tuple = new MyTuple<string, string>(fulname, adress);

            string[] nameAndLitresOfBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = nameAndLitresOfBeer[0];
            int litresOfBeer = int.Parse(nameAndLitresOfBeer[1]);

            MyTuple<string, int> beerTuple = new MyTuple<string, int>(name, litresOfBeer);

            string[] integerDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int number = int.Parse(integerDouble[0]);
            double doubleNumber = double.Parse(integerDouble[1]);

            MyTuple<int, double> intDouble = new MyTuple<int, double>(number, doubleNumber);

            Console.WriteLine(tuple.ToString());
            Console.WriteLine(beerTuple.ToString());
            Console.WriteLine(intDouble.ToString());
        }
    }
}
