namespace _07.WorkingHour
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();
            bool isItClose = false;
            if (hour < 10 || hour > 18 || dayOfWeek == "Sunday")
                isItClose = true;
            string outputMessege = isItClose ? "closed" : "open";
            Console.WriteLine(outputMessege);
        }
    }
}
