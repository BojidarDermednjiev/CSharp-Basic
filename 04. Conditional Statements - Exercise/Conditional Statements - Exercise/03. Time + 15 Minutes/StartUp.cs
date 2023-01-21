namespace _03._Time___15_Minutes
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 15;
            if (minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }
            if (hour >= 24)
                hour = 0;
            string finalTime = minutes < 10 ? $"{hour}:{minutes:d2}" : $"{hour}:{minutes}";
            Console.WriteLine(finalTime);
         }
    }
}
