using _08._Threeuple;
using System;

namespace _08.Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nameAdres = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstName = nameAdres[0];
            string lastName = nameAdres[1];
            string adress = nameAdres[2];

            string town = nameAdres[3];            

            if(nameAdres.Length > 4)
            {
                town= $"{nameAdres[3]} {nameAdres[4]}";
            }

            Threeuple<string, string, string> nameAdresTown = new Threeuple<string, string, string>();

            nameAdresTown.item = $"{firstName} {lastName}";
            nameAdresTown.item1 = adress;            
            nameAdresTown.item2 = town;
               

            string[] nameBeerDrunkOrNot = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string name = nameBeerDrunkOrNot[0];
            int beer = int.Parse(nameBeerDrunkOrNot[1]);
            string drunkOrNot = nameBeerDrunkOrNot[2];
            bool IsDrunk = false;

            Threeuple<string, int, string> nameDrunkOrNot = new Threeuple<string, int, string>();

            nameDrunkOrNot.item = name;
            nameDrunkOrNot.item1 = beer;
            nameDrunkOrNot.item2 = drunkOrNot;
            if(nameDrunkOrNot.item2 == "drunk")
            {
                IsDrunk = true;
            }
                       


            string[] nameBalanceBank = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string names = nameBalanceBank[0];
            double balance = double.Parse(nameBalanceBank[1]);
            string bankName = nameBalanceBank[2];

           
            Threeuple<string, double, string> nameBalancbank = new Threeuple<string, double, string>();

            nameBalancbank.item = names;
            nameBalancbank.item1 = balance;
            nameBalancbank.item2 = bankName;

            Console.WriteLine($"{nameAdresTown.item} -> {nameAdresTown.item1} -> {nameAdresTown.item2}");
            Console.WriteLine($"{nameDrunkOrNot.item} -> {nameDrunkOrNot.item1} -> {IsDrunk}");
            Console.WriteLine($"{nameBalancbank.item} -> {nameBalancbank.item1} -> {nameBalancbank.item2}");

        }
    }
}
