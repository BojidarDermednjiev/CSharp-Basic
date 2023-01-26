namespace _03._Vacation
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double moneyNeedForEx = double.Parse(Console.ReadLine());
            double saveMoney = double.Parse(Console.ReadLine());
            int spendDaysCounter = default;
            int daysCounter = default;
            while (saveMoney < moneyNeedForEx)
            {
                string action = Console.ReadLine();
                double amountSaveSpent = double.Parse(Console.ReadLine());
                daysCounter++;
                if (action == "spend")
                {
                    spendDaysCounter++;
                    saveMoney -= amountSaveSpent;
                    if (saveMoney < 0)
                        saveMoney = 0;
                }
                else if (action == "save")
                {
                    spendDaysCounter = 0;
                    saveMoney += amountSaveSpent;
                }
                if (spendDaysCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysCounter);
                    break;
                }
            }
            if (saveMoney >= moneyNeedForEx)
                Console.WriteLine($"You saved the money for {daysCounter} days.");
        }
    }
}
