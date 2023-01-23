namespace _12.TradeCom
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string nameOfTheCity = Console.ReadLine();
            double readFromConsoleCommission = double.Parse(Console.ReadLine());
            if (0 <= readFromConsoleCommission && readFromConsoleCommission <= 500)
            {
                if (nameOfTheCity == "Sofia")
                    readFromConsoleCommission *= 0.05;
                else if (nameOfTheCity == "Varna")
                    readFromConsoleCommission *= 0.045;
                else if (nameOfTheCity == "Plovdiv")
                    readFromConsoleCommission *= 0.055;
            }
            else if (500 < readFromConsoleCommission && readFromConsoleCommission <= 1000)
            {
                if (nameOfTheCity == "Sofia")
                    readFromConsoleCommission *= 0.07;
                else if (nameOfTheCity == "Varna")
                    readFromConsoleCommission *= 0.075;
                else if (nameOfTheCity == "Plovdiv")
                    readFromConsoleCommission *= 0.08;
            }
            else if (1000 < readFromConsoleCommission && readFromConsoleCommission <= 10000)
            {
                if (nameOfTheCity == "Sofia")
                    readFromConsoleCommission *= 0.08;
                else if (nameOfTheCity == "Varna")
                    readFromConsoleCommission *= 0.10;
                else if (nameOfTheCity == "Plovdiv")
                    readFromConsoleCommission *= 0.12;
            }
            else if (10000 < readFromConsoleCommission)
            {
                if (nameOfTheCity == "Sofia")
                    readFromConsoleCommission *= 0.12;
                else if (nameOfTheCity == "Varna")
                    readFromConsoleCommission *= 0.13;
                else if (nameOfTheCity == "Plovdiv")
                    readFromConsoleCommission *= 0.145;
            }
            if(nameOfTheCity != "Sofia" && nameOfTheCity != "Varna" && nameOfTheCity != "Plovdiv" || readFromConsoleCommission < 0)
            {
                Console.WriteLine("error");
                return;
            }
            Console.WriteLine($"{readFromConsoleCommission:f2}");
        }
    }
}
