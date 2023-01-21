namespace _06._Repainting
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const double PRODECTEDNAYLONFORSQUATMETER = 1.50;
            const double PAINTFORLITTER = 14.50;
            const double TINNERFORPAINT = 5.00;
            const double VESICLE = 0.40;
            int neededQuantityNaylon = ReadLine();
            int neededQuantityPaint = ReadLine();
            int quantityTinner = ReadLine();
            int neededHoursForDoneTheWork = ReadLine();
            double sumOfNaylon = (neededQuantityNaylon + 2) * PRODECTEDNAYLONFORSQUATMETER;
            double addingPaintProcen = neededQuantityPaint * 0.1;
            double sumOfPaint = (addingPaintProcen + neededQuantityPaint) * PAINTFORLITTER;
            double sumOfTinner = quantityTinner * TINNERFORPAINT;
            double sumForItems = sumOfNaylon + sumOfPaint + sumOfTinner + VESICLE;
            double sumForWorkMan = ((sumForItems * 30) / 100) * neededHoursForDoneTheWork;
            Console.WriteLine(sumForItems+sumForWorkMan);
        }

        private static int ReadLine()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
