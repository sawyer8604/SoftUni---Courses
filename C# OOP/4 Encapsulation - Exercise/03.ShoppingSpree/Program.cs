using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();

                string inputePeople = Console.ReadLine();

                string[] peopleAndMoney = inputePeople.Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < peopleAndMoney.Length; i+= 2)
                {
                    string name = peopleAndMoney[i];
                    double money = double.Parse(peopleAndMoney[i+1]);

                    Person person = new Person(name, money);

                    people.Add(person);

                }                 

                string inputeProducts = Console.ReadLine();

                string[] productsAndCost = inputeProducts.Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < productsAndCost.Length; i += 2)
                {
                    string name = productsAndCost[i];
                    double cost = double.Parse(productsAndCost[i + 1]);

                    Product product = new Product(name, cost);

                    products.Add(product);

                }

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmdArguments = command.Split(" ");

                    string name = cmdArguments[0];
                    string product = cmdArguments[1];

                    Person searchedPerson = people.FirstOrDefault(p => p.Name == name);
                    Product searchedProduct = products.FirstOrDefault(p => p.Name == product);

                    searchedPerson.AddProduct(searchedProduct);
                }

                foreach (var item in people)
                {
                    Console.WriteLine(item);
                }
               
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
