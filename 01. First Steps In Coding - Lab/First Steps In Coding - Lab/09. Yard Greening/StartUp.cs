namespace _09._Yard_Greening
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const double PRICEFORONESQUATEMETER = 7.61;
            const double DISCOUNT = 0.18;
            double landscapingАrea = double.Parse(Console.ReadLine());
            Console.WriteLine($"The final price is: {Math.Abs((landscapingАrea * PRICEFORONESQUATEMETER) - ((landscapingАrea * PRICEFORONESQUATEMETER) * DISCOUNT)):f2} lv." + Environment.NewLine + $"The discount is: {((landscapingАrea * PRICEFORONESQUATEMETER) * DISCOUNT):f2} lv.");
        }
    }
}
