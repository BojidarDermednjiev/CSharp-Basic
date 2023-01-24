namespace _01._Cinema
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const decimal PREMIERE = 12.00m;
            const decimal NORMAL = 7.50m;
            const decimal DISCOUNT = 5.00m;
            var typeOfProjection = Console.ReadLine();
            var numberOfRows = int.Parse(Console.ReadLine());
            var numberOfCols = int.Parse(Console.ReadLine());
            decimal income = default(decimal);
            if (typeOfProjection == "Premiere")
                income = numberOfRows * numberOfCols * PREMIERE;
            else if(typeOfProjection == "Normal")
                income = numberOfRows * numberOfCols * NORMAL;
            else if(typeOfProjection == "Discount")
                income= numberOfRows * numberOfCols * DISCOUNT;
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
