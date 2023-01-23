namespace _02.WeekWorkDay
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> dayOfWeek = new Dictionary<string, string>()
            {
                {"Monday", "Working day"},
                {"Tuesday", "Working day"},
                {"Wednesday", "Working day"},
                {"Thursday", "Working day"},
                {"Friday", "Working day"},
                {"Saturday", "Weekend"},
                {"Sunday" , "Weekend"}
            };
            string readDayOfTheWeek = Console.ReadLine();
            string outputMessege = dayOfWeek.ContainsKey(readDayOfTheWeek) ? dayOfWeek.FirstOrDefault(x => x.Key == readDayOfTheWeek).Value : "Error";
            Console.WriteLine(outputMessege);
        }
    }
}
