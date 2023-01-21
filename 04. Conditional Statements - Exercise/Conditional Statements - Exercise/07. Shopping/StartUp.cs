namespace _07._Shopping
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            decimal budgetPerPeter = decimal.Parse(Console.ReadLine());
            int numberOfGPU = int.Parse(Console.ReadLine());
            int numberOfCPU = int.Parse(Console.ReadLine());
            int numberOfRAM = int.Parse(Console.ReadLine());
            decimal priceForGPU = 250 * numberOfGPU;
            decimal priceForCPU = (priceForGPU * 0.35m) * numberOfCPU;
            decimal priceForRAM = (priceForGPU * 0.1m) * numberOfRAM;
            decimal sum = priceForGPU + priceForCPU + priceForRAM;
            if (numberOfGPU > numberOfCPU)
                sum -= sum * 0.15m;
            string isItEnoughMoney = budgetPerPeter - sum >= 0 ? $"You have {(budgetPerPeter - sum):f2} leva left!" : $"Not enough money! You need {Math.Abs(budgetPerPeter - sum):f2} leva more!";
            Console.WriteLine(isItEnoughMoney);
        }
    }
}
