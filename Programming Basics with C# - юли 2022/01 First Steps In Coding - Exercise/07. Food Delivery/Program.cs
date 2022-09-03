using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumberOfChikenMenus = int.Parse(Console.ReadLine());
            int NumberOfFishMenus = int.Parse(Console.ReadLine());
            int NumberOfVegeterianMeuns = int.Parse(Console.ReadLine());

            double chikenMenu = 10.35;
            double fishMenu = 12.40;
            double vegeterianMenu = 8.15;

            double chikenMenuPrice = NumberOfChikenMenus * chikenMenu;
            double fishMenuPrice = NumberOfFishMenus * fishMenu;
            double vegeterianMenuPrice = NumberOfVegeterianMeuns * vegeterianMenu;

            double desertPrice = (chikenMenuPrice + fishMenuPrice + vegeterianMenuPrice) * 0.2;
            double deliveryPrice = 2.50;
            double priceOfAll = chikenMenuPrice + fishMenuPrice + vegeterianMenuPrice + desertPrice + deliveryPrice;

            Console.WriteLine(priceOfAll);



        }
    }
}
