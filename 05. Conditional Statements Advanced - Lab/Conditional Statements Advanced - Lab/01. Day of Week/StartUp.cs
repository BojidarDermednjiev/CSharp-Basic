namespace _01._Day_of_Week
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            Dictionary<int, string> dayOfWeek = new Dictionary<int, string>()
            {
                {1 , "Monday"},
                {2 , "Tuesday"},
                {3 , "Wednesday"},
                {4 , "Thursday"},
                {5 , "Friday"},
                {6 , "Saturday"},
                {7 , "Sunday" }
            };
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            string outputMessege = dayOfWeek.ContainsKey(readNumberFromConsole) ? dayOfWeek.FirstOrDefault(x => x.Key == readNumberFromConsole).Value : "Error";
            Console.WriteLine(outputMessege);
        }
    }
}
