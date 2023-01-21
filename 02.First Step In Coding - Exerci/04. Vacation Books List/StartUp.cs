namespace _04._Vacation_Books_List
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int numberOfPages = ReadLine();
            int pagesPerHour = ReadLine();
            int requiredDays = ReadLine();
            //need time for read the book
            Console.WriteLine((numberOfPages / pagesPerHour) / requiredDays);
        }

        private static int ReadLine()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
