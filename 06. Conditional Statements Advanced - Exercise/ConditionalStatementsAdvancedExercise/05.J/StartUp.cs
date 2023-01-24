namespace _05.J
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double totalprice = 0.0;
            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        totalprice = budget * 0.30;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {totalprice:f2}");
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        totalprice = budget * 0.40;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Camp - {totalprice:f2}");
                    }
                    else
                    {
                        totalprice = budget * 0.90;
                        Console.WriteLine("Somewhere in Europe");
                        Console.WriteLine($"Hotel - {totalprice:f2}");
                    }
                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        totalprice = budget * 0.70;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {totalprice:f2}");
                    }
                    else if (budget > 100 && budget <= 1000)
                    {
                        totalprice = budget * 0.80;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {totalprice:f2}");
                    }
                    else
                    {
                        totalprice = budget * 0.90;
                        Console.WriteLine("Somewhere in Europe");
                        Console.WriteLine($"Hotel - {totalprice:f2}");
                    }
                    break;
                default:
                    Console.WriteLine("Error 404");
                    break;
            }
        }
    }
}
