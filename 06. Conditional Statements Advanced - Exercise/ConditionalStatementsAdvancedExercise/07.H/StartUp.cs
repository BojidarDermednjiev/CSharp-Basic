namespace _07.H
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const double mayAndOctStudioPrice = 50;
            const double mayAndOctApartmentPrice = 65;
            const double juneAndSeptemperStudioPrice = 75.20;
            const double juneAndSeptemperApartmentPrice = 68.70;
            const double julyAndAugustStudioPrice = 76;
            const double julyAndAugustApartmentPrice = 77;
            string season = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double totalMoneyForStudio = 0;
            double totalMoneyForApartment = 0;
            if (season == "May" || season == "October")
            {
                totalMoneyForStudio = nights * mayAndOctStudioPrice;
                totalMoneyForApartment = nights * mayAndOctApartmentPrice;
                if (nights > 7 && nights < 14)
                {
                    totalMoneyForStudio -= totalMoneyForStudio * 0.05;
                }
                else if (nights > 14)
                {
                    totalMoneyForStudio -= totalMoneyForStudio * 0.30;
                }
            }
            else if (season == "June" || season == "September")
            {
                totalMoneyForStudio = nights * juneAndSeptemperStudioPrice;
                totalMoneyForApartment = nights * juneAndSeptemperApartmentPrice;
                if (nights > 14)
                {
                    totalMoneyForStudio -= totalMoneyForStudio * 0.20;
                }
            }
            else if (season == "July" || season == "August")
            {
                totalMoneyForStudio = nights * julyAndAugustStudioPrice;
                totalMoneyForApartment = nights * julyAndAugustApartmentPrice;
            }
            if (nights > 14)
            {
                totalMoneyForApartment -= totalMoneyForApartment * 0.10;
            }
            Console.WriteLine($"Apartment: {totalMoneyForApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyForStudio:f2} lv.");
        }
    }
}
