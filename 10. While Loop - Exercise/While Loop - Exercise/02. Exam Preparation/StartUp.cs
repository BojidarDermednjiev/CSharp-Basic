namespace _02._Exam_Preparation
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int poorGrades = int.Parse(Console.ReadLine());
            string problem = Console.ReadLine();
            int poorGradesCounter = default;
            int gradeSum = default;
            int gradesCounter = default;
            string lastProblem = string.Empty;
            while (problem != "Enough")
            {
                var grade = int.Parse(Console.ReadLine());
                gradeSum += grade;
                gradesCounter++;
                if (grade <= 4)
                {
                    poorGradesCounter++;
                    if (poorGradesCounter == poorGrades)
                    {
                        Console.WriteLine($"You need a break, {poorGradesCounter} poor grades.");
                        break;
                    }
                }
                lastProblem = problem;
                problem = Console.ReadLine();
            }
            double averageGrade = (double)gradeSum / gradesCounter;
            if (problem == "Enough")
            {
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {gradesCounter}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
