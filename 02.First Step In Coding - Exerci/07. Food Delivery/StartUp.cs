namespace _07._Food_Delivery
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const double CHIKENMENU = 10.35;
            const double FISHMENU = 12.40;
            const double VEGETABLEMENU = 8.15;
            const double DELIVERY = 2.50;
            int countOfChikenMenu = int.Parse(Console.ReadLine());
            int countOfFishMenu = int.Parse(Console.ReadLine());
            int countOfVegetableMenu = int.Parse(Console.ReadLine());
           double priceForChikenMenu = countOfChikenMenu* CHIKENMENU;
            double priceForFishMenu = countOfFishMenu* FISHMENU;
            double priceForVegetableMenu = countOfVegetableMenu* VEGETABLEMENU;
            double priceForDessert = (priceForChikenMenu + priceForFishMenu + priceForVegetableMenu) * 20 / 100;
            Console.WriteLine(priceForChikenMenu + priceForFishMenu + priceForVegetableMenu + priceForDessert + DELIVERY);
        }
    }
}
