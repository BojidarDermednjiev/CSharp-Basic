namespace _04._Toy_Shop
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const double PUZZEL = 2.60;
            const double SPEAKINGDOLL = 3;
            const double TEDDYBEAR = 4.10;
            const double MINION = 8.20;
            const double TRUCK = 2;
            double priceForTheExcursion = double.Parse(Console.ReadLine());
            int numberOfPuzzels = int.Parse(Console.ReadLine());
            int numberOfSpeakingDoll = int.Parse(Console.ReadLine());
            int numberOfTeddyToys = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTrucks = int.Parse(Console.ReadLine());
            double sum = numberOfPuzzels * PUZZEL + numberOfSpeakingDoll * SPEAKINGDOLL + numberOfTeddyToys * TEDDYBEAR + numberOfMinions * MINION + numberOfTrucks * TRUCK;
            int numberOfAllToys = numberOfPuzzels + numberOfSpeakingDoll + numberOfTeddyToys + numberOfMinions + numberOfTrucks;
            if (numberOfAllToys >= 50)
                sum -= sum * 0.25;
            sum -= sum * 0.1;
            if (sum >= priceForTheExcursion)
                Console.WriteLine($"Yes! {(sum - priceForTheExcursion):f2} lv left.");
            else 
                Console.WriteLine($"Not enough money! {Math.Abs(sum - priceForTheExcursion):f2} lv needed.");

        }
    }
}
