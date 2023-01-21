namespace _05._Supplies_for_School
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const double PACKETPEN = 5.80;
            const double PACKETMARKERS = 7.20;
            const double DETEGRENTFORLITTER = 1.20;
            double pen = ReadLine();
            double markers = ReadLine();
            double litterForCleanOfTable = ReadLine();
            double dicount = ReadLine();
            Console.WriteLine((pen * PACKETPEN + markers * PACKETMARKERS + litterForCleanOfTable * DETEGRENTFORLITTER) - (pen * PACKETPEN + markers * PACKETMARKERS + litterForCleanOfTable * DETEGRENTFORLITTER) * (dicount / 100));
        }

        private static double ReadLine()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}
