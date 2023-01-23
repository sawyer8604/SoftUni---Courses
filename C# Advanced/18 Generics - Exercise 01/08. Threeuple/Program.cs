using System;

namespace _08._Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fulNameAndAdress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string fulname = fulNameAndAdress[0] + " " + fulNameAndAdress[1];
            string adress = fulNameAndAdress[2];
            string town = fulNameAndAdress[3];

            MyTuple<string, string, string> tuple = new MyTuple<string, string, string>(fulname, adress, town);

            string[] nameAndLitresOfBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = nameAndLitresOfBeer[0];
            int litresOfBeer = int.Parse(nameAndLitresOfBeer[1]);
            bool drunkOrNot = nameAndLitresOfBeer[2] == "drunk";

            MyTuple<string, int, bool> beerTuple = new MyTuple<string, int, bool>(name, litresOfBeer, drunkOrNot);

            string[] namebancAccountBalance = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string nameOf = namebancAccountBalance[0];
            double doubleNumber = double.Parse(namebancAccountBalance[1]);
            string bankName = namebancAccountBalance[2];

            MyTuple<string, double, string> intDouble = new MyTuple<string, double, string>(nameOf, doubleNumber, bankName);

            Console.WriteLine(tuple.ToString());
            Console.WriteLine(beerTuple.ToString());
            Console.WriteLine(intDouble.ToString());
        }
    }
}
