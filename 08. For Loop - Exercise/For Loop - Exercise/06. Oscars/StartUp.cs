namespace _06._Oscars
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            var nameOfActor = Console.ReadLine();
            double pointsOfAcademy = double.Parse(Console.ReadLine());
            int numberOfEvaluative = int.Parse(Console.ReadLine());
            for (int currentEvaluative = 0; currentEvaluative < numberOfEvaluative; currentEvaluative++)
            {
                var nameOfEvalutive = Console.ReadLine();
                var pointOfEvaluative = double.Parse(Console.ReadLine());
                if (pointsOfAcademy >= 1250.5)
                    break;
                pointsOfAcademy += (nameOfEvalutive.Length * pointOfEvaluative) / 2;
            }
            string outputMessage = pointsOfAcademy >= 1250.5 ? $"Congratulations, {nameOfActor} got a nominee for leading role with {pointsOfAcademy:f1}!" : $"Sorry, {nameOfActor} you need {Math.Abs(pointsOfAcademy - 1250.5):f1} more!";
            Console.WriteLine(outputMessage);
        }
    }
}
