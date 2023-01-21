namespace _07._Area_of_Figures
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            double faceOfTheFigure = default(double);
            if (figure == "square")
            {
                double lengthOfTheWidth = double.Parse(Console.ReadLine());
                faceOfTheFigure = Math.Pow(lengthOfTheWidth, 2);
            }
            else if (figure == "circle")
            {
                double radiusOfTheCircle = double.Parse(Console.ReadLine());
                faceOfTheFigure = Math.Pow(radiusOfTheCircle, 2) * Math.PI;
            }
            else if (figure == "rectangle")
            {
                double firstLength = double.Parse(Console.ReadLine());
                double secondLength = double.Parse(Console.ReadLine());
                faceOfTheFigure = firstLength * secondLength;
            }
            else if (figure == "triangle")
            {
                double length = double.Parse(Console.ReadLine());
                double heigth = double.Parse(Console.ReadLine());
                faceOfTheFigure = length * heigth / 2;
            }
            Console.WriteLine($"{faceOfTheFigure:f3}");
        }
    }
}
