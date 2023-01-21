namespace _01._Sum_Seconds
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totalTime = firstTime + secondTime + thirdTime;
            int minutes = totalTime / 60;
            int seconds = totalTime % 60;
            string finalTime = seconds < 10 ? $"{minutes}:{seconds:d2}" : $"{minutes}:{seconds}";
            Console.WriteLine(finalTime);
        }
    }
}
