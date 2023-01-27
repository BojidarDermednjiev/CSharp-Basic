namespace _04._Train_The_Trainers
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int numberOfJury = int.Parse(Console.ReadLine());
            string numberOfProject;
            double totalSum = default;
            int totalNumOfProj = default;
            while ((numberOfProject = Console.ReadLine()) != "Finish")
            {
                double sum = default;
                totalNumOfProj++;
                for (int i = 0; i < numberOfJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }
                double avarageGrade = sum / numberOfJury;
                totalSum += avarageGrade;
                Console.WriteLine($"{numberOfProject} - {avarageGrade:f2}.");
            }
            double totalAvarage = totalSum / totalNumOfProj;
            Console.WriteLine($"Student's final assessment is {totalAvarage:f2}.");
        }
    }
}
