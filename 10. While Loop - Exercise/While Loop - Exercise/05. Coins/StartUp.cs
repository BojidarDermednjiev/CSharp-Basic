namespace _05._Coins
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            double sum = double.Parse(Console.ReadLine());
            int coinsCounter = 0;
            while (sum > 0)
            {
                sum = Math.Round(sum, 2);
                if (sum >= 2.00)
                    sum -= 2.00;
                else if (sum >= 1.00)
                    sum -= 1.00;
                else if (sum >= 0.50)
                    sum -= 0.50;
                else if (sum >= 0.20)
                    sum -= 0.20;
                else if (sum >= 0.10)
                    sum -= 0.10;
                else if (sum >= 0.05)
                    sum -= 0.05;
                else if (sum >= 0.02)
                    sum -= 0.02;
                else if (sum >= 0.01)
                    sum -= 0.01;
                coinsCounter++;

            }
            Console.WriteLine(coinsCounter);
        }
    }
}
