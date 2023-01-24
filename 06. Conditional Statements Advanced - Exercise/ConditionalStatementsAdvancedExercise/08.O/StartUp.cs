namespace _08.O
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int hoursExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minutesArrive = int.Parse(Console.ReadLine());
            int examInMinutes = hoursExam * 60 + minutesExam;
            int arriveInMinutes = hourArrive * 60 + minutesArrive;
            if (arriveInMinutes > examInMinutes)
            {
                Console.WriteLine("Late");
                int lateInMinutes = arriveInMinutes - examInMinutes;
                if (lateInMinutes < 60)
                    Console.WriteLine($"{lateInMinutes} minutes after the start");
                else
                {
                    int lateHours = lateInMinutes / 60;
                    int lateMinutes = lateInMinutes % 60;
                    Console.WriteLine($"{lateHours}:{lateMinutes:d2} hours after the start” ");
                }
            }
            else if (arriveInMinutes == examInMinutes || examInMinutes - arriveInMinutes <= 30)
            {
                Console.WriteLine("On time");
                if (arriveInMinutes != examInMinutes)
                    Console.WriteLine($"{examInMinutes - arriveInMinutes} minutes before the start");
            }
            else if (examInMinutes - arriveInMinutes > 30)
            {
                Console.WriteLine("Early");
                int earlyinMinutes = examInMinutes - arriveInMinutes;
                if (earlyinMinutes < 60)
                    Console.WriteLine($"{earlyinMinutes} minutes before the start");
                else
                {
                    int earlyHour = earlyinMinutes / 60;
                    int earlyMinutes = earlyinMinutes % 60;
                    Console.WriteLine($"{earlyHour}:{earlyMinutes:d2} hours before the start” ");
                }
            }
        }
    }
}
