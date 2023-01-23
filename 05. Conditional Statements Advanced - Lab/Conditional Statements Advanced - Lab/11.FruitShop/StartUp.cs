namespace _11.FruitShop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, double>> market = new Dictionary<string, Dictionary<string, double>>()
            {
                { "Monday", new Dictionary<string, double>()
                {
                    { "banana", 2.50},
                    { "apple", 1.20},
                    { "orange", 0.85},
                    { "grapefruit", 1.45},
                    { "kiwi", 2.70},
                    { "pineapple", 5.50},
                    { "grapes", 3.85},
                }},
                { "Tuesday", new Dictionary<string, double>()
                {
                    { "banana", 2.50},
                    { "apple", 1.20},
                    { "orange", 0.85},
                    { "grapefruit", 1.45},
                    { "kiwi", 2.70},
                    { "pineapple", 5.50},
                    { "grapes", 3.85},
                }},
                { "Wednesday", new Dictionary<string, double>()
                {
                    { "banana", 2.50},
                    { "apple", 1.20},
                    { "orange", 0.85},
                    { "grapefruit", 1.45},
                    { "kiwi", 2.70},
                    { "pineapple", 5.50},
                    { "grapes", 3.85},
                }},
                { "Thursday", new Dictionary<string, double>()
                {
                    { "banana", 2.50},
                    { "apple", 1.20},
                    { "orange", 0.85},
                    { "grapefruit", 1.45},
                    { "kiwi", 2.70},
                    { "pineapple", 5.50},
                    { "grapes", 3.85},
                }},
                { "Friday", new Dictionary<string, double>()
                {
                    { "banana", 2.50},
                    { "apple", 1.20},
                    { "orange", 0.85},
                    { "grapefruit", 1.45},
                    { "kiwi", 2.70},
                    { "pineapple", 5.50},
                    { "grapes", 3.85},
                }},
                 { "Saturday", new Dictionary<string, double>()
                {
                    { "banana", 2.70},
                    { "apple", 1.25},
                    { "orange", 0.90},
                    { "grapefruit", 1.60},
                    { "kiwi", 3.00},
                    { "pineapple", 5.60},
                    { "grapes", 4.20},
                }},
                  { "Sunday", new Dictionary<string, double>()
                {
                    { "banana", 2.70},
                    { "apple", 1.25},
                    { "orange", 0.90},
                    { "grapefruit", 1.60},
                    { "kiwi", 3.00},
                    { "pineapple", 5.60},
                    { "grapes", 4.20},
                }},
            };
            string product = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double countOfProduct = double.Parse(Console.ReadLine());
            try
            {

                var sum = market.FirstOrDefault(x => x.Key == dayOfTheWeek).Value.Where(x => x.Key == product).Sum(x => x.Value * countOfProduct);
                string outputMessege = sum > 0 ? $"{sum:f2}" : "error";
                Console.WriteLine(outputMessege);
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }
        }
    }
}
