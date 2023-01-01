using System;

namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAdres = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstName = nameAdres[0];
            string lastName = nameAdres[1];
            string adress = nameAdres[2];

            string[] nameAndBeerToDrink = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = nameAndBeerToDrink[0];
            int nameLitres = int.Parse(nameAndBeerToDrink[1]);

            string[] priceLitres = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int litres = int.Parse(priceLitres[0]);
            double price = double.Parse(priceLitres[1]);

            Tuple<string, string> nameAndAdress = new Tuple<string, string>();

            nameAndAdress.Item1 = $"{firstName} {lastName}";
            nameAndAdress.Item2 = adress;

            Console.WriteLine($"{nameAndAdress.Item1} -> {nameAndAdress.Item2}");


            Tuple<string, int> nameBeer = new Tuple<string, int>();

            nameBeer.Item1 = name;
            nameBeer.Item2 = nameLitres;

            Console.WriteLine($"{nameBeer.Item1} -> {nameBeer.Item2}");

            Tuple<int, double> priceAndLitres = new Tuple<int, double>();

            priceAndLitres.Item1 = litres;
            priceAndLitres.Item2 = price;

            Console.WriteLine($"{priceAndLitres.Item1} -> {priceAndLitres.Item2}");


        }
    }
}
