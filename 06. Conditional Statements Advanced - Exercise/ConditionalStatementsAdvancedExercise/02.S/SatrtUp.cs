namespace _02.S
{
    using System;
    public class SatrtUp
    {
        static void Main()
        {
            var degrees = int.Parse(Console.ReadLine());
            var whatTimeIsIt = Console.ReadLine();
            var outfit = String.Empty;
            var shoes = String.Empty;
            if (10 <= degrees && degrees <= 18)
                DegreesTenToEighteen(whatTimeIsIt, ref outfit, ref shoes);
            else if (degrees > 18 && degrees <= 24)
                DegreesMoreThenEighteenToTwentyFour(whatTimeIsIt, ref outfit, ref shoes);
            else if (degrees >= 25)
                DegreesTwentyFiveOrMore(whatTimeIsIt, ref outfit, ref shoes);
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
        private static void DegreesTenToEighteen(string whatTimeIsIt, ref string outfit, ref string shoes)
        {
            switch (whatTimeIsIt)
            {
                case "Morning":
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    break;
                case "Afternoon":
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
            }
        }
        private static void DegreesMoreThenEighteenToTwentyFour(string whatTimeIsIt, ref string outfit, ref string shoes)
        {
            switch (whatTimeIsIt)
            {
                case "Morning":
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
                case "Afternoon":
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    break;
            }
        }
        private static void DegreesTwentyFiveOrMore(string whatTimeIsIt, ref string outfit, ref string shoes)
        {
            switch (whatTimeIsIt)
            {
                case "Morning":
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    break;
                case "Afternoon":
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    break;
                case "Evening":
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    break;
            }
        }
    }
}
