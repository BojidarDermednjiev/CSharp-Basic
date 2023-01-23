namespace _05._Small_Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, double>> market = new Dictionary<string,Dictionary<string, double>>()
            {
                { "Sofia", new Dictionary<string, double>()
                {
                    { "coffee", 0.50},
                    { "water", 0.80},
                    { "beer", 1.20},
                    { "sweets", 1.45},
                    { "peanuts", 1.60},
                }},
                 { "Plovdiv", new Dictionary<string, double>()
                {
                    { "coffee", 0.40},
                    { "water", 0.70},
                    { "beer", 1.15},
                    { "sweets", 1.30},
                    { "peanuts", 1.50},
                }},
                  { "Varna", new Dictionary<string, double>()
                {
                    { "coffee", 0.45},
                    { "water", 0.70},
                    { "beer", 1.10},
                    { "sweets", 1.35},
                    { "peanuts", 1.55},
                }},
            };
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double countOfProduct = double.Parse(Console.ReadLine());
            var sum = market.FirstOrDefault(x => x.Key == city).Value.Where(x => x.Key == product).Sum(x => x.Value * countOfProduct);
            Console.WriteLine($"{sum}");
        }
    }
}
