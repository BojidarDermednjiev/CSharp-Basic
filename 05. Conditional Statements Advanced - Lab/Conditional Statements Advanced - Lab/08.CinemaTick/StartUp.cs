namespace _08.CinemaTick
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            var ticketForCinema = new Dictionary<string, int>()
            {
                {"Monday", 12 },
                { "Tuesday", 12 },
                { "Wednesday", 14 },
                { "Thursday", 14 },
                { "Friday", 12 },
                { "Saturday", 16 },
                { "Sunday", 16 },
            };
            string dayOfTheWeek = Console.ReadLine();
            Console.WriteLine(ticketForCinema.FirstOrDefault(x => x.Key == dayOfTheWeek).Value);
        }
    }
}
