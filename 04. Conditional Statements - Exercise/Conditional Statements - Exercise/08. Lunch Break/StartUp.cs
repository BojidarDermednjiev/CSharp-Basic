namespace _08._Lunch_Break
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var nameOfSerial = Console.ReadLine();
            double howLongIsItOneEpisod = double.Parse(Console.ReadLine());
            double breakingTime = double.Parse(Console.ReadLine());
            double lunchTime = breakingTime / 8;
            double relax = breakingTime / 4;
            double leftTime = breakingTime - lunchTime - relax;
            var outputMessege = leftTime >= howLongIsItOneEpisod ? $"You have enough time to watch {nameOfSerial} and left with {Math.Ceiling(leftTime - howLongIsItOneEpisod)} minutes free time." : $"You don't have enough time to watch {nameOfSerial}, you need {Math.Ceiling(howLongIsItOneEpisod - leftTime)} more minutes.";
            Console.WriteLine(outputMessege);
        }
    }
}
