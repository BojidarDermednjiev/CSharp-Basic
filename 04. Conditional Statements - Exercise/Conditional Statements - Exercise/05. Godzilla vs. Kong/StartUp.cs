namespace _05._Godzilla_vs._Kong
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string outputMessege = String.Empty;
            double budgetForFilm = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double priceForClothesPerOneStatist = double.Parse(Console.ReadLine());
            double decorFeeSum = budgetForFilm * 0.1;
            double clothesPrice = priceForClothesPerOneStatist * statist;
            if (statist > 150)
                clothesPrice -= clothesPrice * 0.1;
            double finalSumForFilm = decorFeeSum + clothesPrice;
            if (finalSumForFilm <= budgetForFilm)
                outputMessege = "Action!" + Environment.NewLine + $"Wingard starts filming with {(budgetForFilm - finalSumForFilm):f2} leva left.";
            else
                outputMessege = "Not enough money!" + Environment.NewLine + $"Wingard needs {Math.Abs(budgetForFilm - finalSumForFilm):f2} leva more.";
            Console.WriteLine(outputMessege);
        }
    }
}
