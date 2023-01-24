namespace _03.N
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const double priceRoses = 5.00;
            const double priceDahlias = 3.80;
            const double priceTulips = 2.80;
            const double priceNarcissus = 3.00;
            const double priceGladiolus = 2.50;
            string flowers = Console.ReadLine();
            int numerOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double totalMoney = 0;
            if (flowers == "Roses")
            {
                if (numerOfFlowers > 80)
                    totalMoney -= numerOfFlowers * priceRoses * 0.10;
                totalMoney += numerOfFlowers * priceRoses;
            }
            else if (flowers == "Dahlias")
            {
                if (numerOfFlowers > 90)
                    totalMoney -= numerOfFlowers * priceDahlias * 0.15;
                totalMoney += numerOfFlowers * priceDahlias;
            }
            else if (flowers == "Tulips")
            {
                if (numerOfFlowers > 80)
                    totalMoney -= numerOfFlowers * priceTulips * 0.15;
                totalMoney += numerOfFlowers * priceTulips;
            }
            else if (flowers == "Narcissus")
            {
                if (numerOfFlowers < 120)
                    totalMoney += numerOfFlowers * priceNarcissus * 0.15;
                totalMoney += numerOfFlowers * priceNarcissus;
            }
            else if (flowers == "Gladiolus")
            {
                if (numerOfFlowers < 80)
                    totalMoney += numerOfFlowers * priceGladiolus * 0.20;
                totalMoney += numerOfFlowers * priceGladiolus;
            }
            if (budget >= totalMoney)
            {
                double moneyLeft = budget - totalMoney;
                Console.WriteLine($"Hey, you have a great garden with {numerOfFlowers} {flowers} and {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = totalMoney - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }
        }
    }
}
