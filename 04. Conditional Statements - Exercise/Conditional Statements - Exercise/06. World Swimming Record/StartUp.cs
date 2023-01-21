namespace _06._World_Swimming_Record
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var outputMessege = String.Empty;
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());
            double swimmingTimePerIvan = (distanceInMeters * timeInSeconds) + Math.Floor(distanceInMeters / 15) * 12.5;
            if (swimmingTimePerIvan < recordInSeconds)
                outputMessege = $"Yes, he succeeded! The new world record is {swimmingTimePerIvan:f2} seconds.";
            else
                outputMessege = $"No, he failed! He was {Math.Abs(swimmingTimePerIvan - recordInSeconds):f2} seconds slower.";
            Console.WriteLine(outputMessege);
        }
    }
}
