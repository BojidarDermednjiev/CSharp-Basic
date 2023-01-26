namespace _08._Graduation
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string studentName = Console.ReadLine();
            int course = 1;
            double averageGrade = default;
            int cutCounter = default;
            bool hasBeenCut = false;
            while (course <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                if (grade < 4)
                {
                    cutCounter++;
                    if (cutCounter == 2)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {course - 1} grade");
                        hasBeenCut = true;
                        break;
                    }
                }
                course++;
            }
            if (!hasBeenCut)
                Console.WriteLine($"{studentName} graduated. Average grade: {(averageGrade / 12):f2}");
        }
    }
}
