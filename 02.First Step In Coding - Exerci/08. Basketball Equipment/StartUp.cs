namespace _08._Basketball_Equipment
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int annualFeeForBasketballPratices = int.Parse(Console.ReadLine());
            double priceForSneakers = annualFeeForBasketballPratices - (annualFeeForBasketballPratices * 0.4);
            double basketballOutfite = priceForSneakers - (priceForSneakers * 0.2);
            double priceBallForBasketball = basketballOutfite / 4;
            double accessoryForBasketball = priceBallForBasketball / 5;
            double finallSum = annualFeeForBasketballPratices + priceForSneakers + basketballOutfite + priceBallForBasketball + accessoryForBasketball;
            Console.WriteLine($"{finallSum:f2}");
        }
    }
}
