using System;

namespace _04.PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split(' ');
                string pizzaNAme = pizzaInfo[1];


                string[] products = Console.ReadLine().Split(' ');

                string type = products[1];
                string technique = products[2];
                double grams = double.Parse(products[3]);

                Dough dough = new Dough(type, technique, grams);

                Pizza pizza = new Pizza(pizzaNAme, dough);

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] topping = command.Split(' ');

                    string toppingName = topping[1];
                    double gramss = double.Parse(topping[2]);

                    Topping top = new Topping(toppingName, gramss);

                    pizza.AddToppings(top);


                }

                Console.WriteLine($"{pizzaNAme} - {pizza.Calories:f2} Calories.");
            }
            catch (Exception ae)
            {

                Console.WriteLine(ae.Message);
            }
            
            
            
            
        }
        
    }
}
