using System;

class Vacation
{
    static void Main()
    {

        double neededMoney = double.Parse(Console.ReadLine());
        double moneyOnHand = double.Parse(Console.ReadLine());
        int spendcounter = 0;
        int days = 0;


        while (moneyOnHand < neededMoney)
        {

            days++;
            string command = Console.ReadLine();
            double currentMoney = double.Parse(Console.ReadLine());

            switch (command)
            {

                case "spend":
                    spendcounter++;
                    moneyOnHand -= currentMoney;
                    if (currentMoney > moneyOnHand)
                    {

                        moneyOnHand = 0;
                    }
                    if (spendcounter == 5)
                    {
                        Console.WriteLine($"You can't save the money.\r\n{days}");
                        return;
                    }


                    break;

                case "save":
                    spendcounter = 0;
                    moneyOnHand += currentMoney;
                    if (moneyOnHand >= neededMoney)
                    {
                        Console.WriteLine($"You saved the money for {days} days.");
                        return;

                    }
                    break;

            }

        }


    }
}