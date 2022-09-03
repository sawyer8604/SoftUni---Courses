using System;

namespace _02._Add_Bags_Условие
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOfBaggageOver20Kilos = double.Parse(Console.ReadLine());
            double kilosOfBaggage = double.Parse(Console.ReadLine());
            int dayBeforeLeaving = int.Parse(Console.ReadLine());
            int numberOfBaggage = int.Parse(Console.ReadLine());

            double baggagePrice = 0;


            if (kilosOfBaggage < 10)
            {
                baggagePrice = priceOfBaggageOver20Kilos * 0.2;

            }
            else if (kilosOfBaggage >= 10 && kilosOfBaggage <= 20)
            {
                baggagePrice = priceOfBaggageOver20Kilos * 0.5;
            }
            else if (kilosOfBaggage > 20)
            {
                baggagePrice = priceOfBaggageOver20Kilos;

            }
            if (dayBeforeLeaving > 30)
            {
                baggagePrice *= 1.1;

            }
            else if (dayBeforeLeaving >= 7 && dayBeforeLeaving <= 30)
            {
                baggagePrice *= 1.15;

            }
            else if (dayBeforeLeaving < 7)
            {
                baggagePrice *= 1.4;

            }
            baggagePrice *= numberOfBaggage;
            Console.WriteLine($"The total price of bags is: {baggagePrice:f2} lv.");
        }
    }
}
