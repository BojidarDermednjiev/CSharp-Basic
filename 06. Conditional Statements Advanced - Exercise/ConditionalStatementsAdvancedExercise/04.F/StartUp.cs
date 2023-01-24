namespace _04.F
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFishmans = int.Parse(Console.ReadLine());
            int spring = 3000;
            int summer = 4200;
            int autumn = 4200;
            int winter = 2600;
            double totalPrice = 0.0;
            switch (season)
            {
                case "Spring":
                    totalPrice = spring;
                    if (numberOfFishmans <= 6)
                        totalPrice -= spring * 0.10;
                    else if (numberOfFishmans >= 7 && numberOfFishmans <= 11)
                        totalPrice -= spring * 0.15;
                    else if (numberOfFishmans >= 12)
                        totalPrice -= spring * 0.25;
                    break;
                case "Summer":
                    totalPrice = summer;
                    if (numberOfFishmans <= 6)
                        totalPrice -= summer * 0.10;
                    else if (numberOfFishmans >= 7 && numberOfFishmans <= 11)
                        totalPrice -= summer * 0.15;
                    else if (numberOfFishmans >= 12)
                        totalPrice -= summer * 0.25;
                    break;
                case "Autumn":
                    totalPrice = autumn;
                    if (numberOfFishmans <= 6)
                        totalPrice -= autumn * 0.10;
                    else if (numberOfFishmans >= 7 && numberOfFishmans <= 11)
                        totalPrice -= autumn * 0.15;
                    else if (numberOfFishmans >= 12)
                        totalPrice -= autumn * 0.25;
                    break;
                case "Winter":
                    totalPrice = winter;
                    if (numberOfFishmans <= 6)
                        totalPrice -= winter * 0.10;
                    else if (numberOfFishmans >= 7 && numberOfFishmans <= 11)
                        totalPrice -= winter * 0.15;
                    else if (numberOfFishmans >= 12)
                        totalPrice -= winter * 0.25;
                    break;
                default:
                    Console.WriteLine("Error 404 :P");
                    break;
            }
            if (numberOfFishmans % 2 == 0 && season != "Autumn")
                totalPrice -= totalPrice * 0.05;
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeed = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeed:f2} leva.");
            }
        }
    }
}
