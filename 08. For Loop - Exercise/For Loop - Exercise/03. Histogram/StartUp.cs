namespace _03._Histogram
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            const double bum = 1.0;
            int countOfTheReaderNum = int.Parse(Console.ReadLine());
            int p1 = default;
            int p2 = default;
            int p3 = default;
            int p4 = default;
            int p5 = default;
            for (int currentNumber = 0; currentNumber < countOfTheReaderNum; currentNumber++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                    p1++;
                else if (number < 400)
                    p2++;
                else if (number < 600)
                    p3++;
                else if (number < 800)
                    p4++;
                else
                    p5++;
            }
            double pp1 = bum * p1 / countOfTheReaderNum * 100;
            double pp2 = bum * p2 / countOfTheReaderNum * 100;
            double pp3 = bum * p3 / countOfTheReaderNum * 100;
            double pp4 = bum * p4 / countOfTheReaderNum * 100;
            double pp5 = bum * p5 / countOfTheReaderNum * 100;
            Console.WriteLine($"{pp1:f2}%");
            Console.WriteLine($"{pp2:f2}%");
            Console.WriteLine($"{pp3:f2}%");
            Console.WriteLine($"{pp4:f2}%");
            Console.WriteLine($"{pp5:f2}%");
        }
    }
}
